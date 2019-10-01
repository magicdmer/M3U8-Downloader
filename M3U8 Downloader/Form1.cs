using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Text;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Threading;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;

namespace M3U8_Downloader
{
    public partial class Form1 : Form
    {
        //任务栏进度条的实现。
        TaskbarManager windowsTaskbar = TaskbarManager.Instance;
     

        [DllImport("kernel32.dll")]
        static extern bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        [DllImport("user32.dll")]
        public static extern bool FlashWindow(IntPtr hWnd,bool bInvert );


        string CurrentLanguage = "default";


        int ffmpegid = -1;
        string m_path;
        string m_proxy;

        //不影响点击任务栏图标最大最小化
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Init();
            Control.CheckForIllegalCrossThreadCalls = false;  //禁止编译器对跨线程访问做检查
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (ffmpegid != -1)
            {
                Stop();
            }
        }


        //格式化大小输出
        public static String FormatFileSize(Double fileSize)
        {
            if (fileSize < 0)
            {
                throw new ArgumentOutOfRangeException("fileSize");
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                return string.Format("{0:########0.00} GB", ((Double)fileSize) / (1024 * 1024 * 1024));
            }
            else if (fileSize >= 1024 * 1024)
            {
                return string.Format("{0:####0.00} MB", ((Double)fileSize) / (1024 * 1024));
            }
            else if (fileSize >= 1024)
            {
                return string.Format("{0:####0.00} KB", ((Double)fileSize) / 1024);
            }
            else
            {
                return string.Format("{0} bytes", fileSize);
            }
        }

        private void textBox_Info_TextChanged()
        {

            Regex regex = new Regex(@"(\d\d[.:]){3}\d\d", RegexOptions.Compiled | RegexOptions.Singleline);//取视频时长以及Time属性
            var time = regex.Matches(textBox_forRegex.Text);

            Regex size = new Regex(@"[1-9][0-9]{0,}kB time", RegexOptions.Compiled | RegexOptions.Singleline);//取已下载大小
            var sizekb = size.Matches(textBox_forRegex.Text);

            Regex duration = new Regex(@"Duration: (\d\d[.:]){3}\d\d", RegexOptions.Compiled | RegexOptions.Singleline);//取总视频时长
            string label5 = "[总时长：" + duration.Match(m_outPut).Value.Replace("Duration: ", "") + "]";

            string label6 = "[已下载：，]";
            if (time.Count > 0 && sizekb.Count > 0)
            {
                label6 = "[已下载：" + time.OfType<Match>().Last() + "，" + FormatFileSize(Convert.ToDouble(sizekb.OfType<Match>().Last().ToString().Replace("kB time", "")) * 1024) + "]";
            }

            Regex fps = new Regex(@", (\S+)\sfps", RegexOptions.Compiled | RegexOptions.Singleline);//取视频帧数
            Regex resolution = new Regex(@", \d{2,}x\d{2,}", RegexOptions.Compiled | RegexOptions.Singleline);//取视频分辨率
            label7.Text = "[视频信息：" + resolution.Match(m_outPut).Value.Replace(", ", "") + "，" + fps.Match(m_outPut).Value.Replace(", ", "") + "]";

            if (time.Count > 0 && sizekb.Count > 0)  //防止程序太快 无法截取
            {
                try
                {
                    Double All = Convert.ToDouble(Convert.ToDouble(label5.Substring(5, 2)) * 60 * 60 + Convert.ToDouble(label5.Substring(8, 2)) * 60
                    + Convert.ToDouble(label5.Substring(11, 2)) + Convert.ToDouble(label5.Substring(14, 2)) / 100);
                    Double Downloaded = Convert.ToDouble(Convert.ToDouble(label6.Substring(5, 2)) * 60 * 60 + Convert.ToDouble(label6.Substring(8, 2)) * 60
                    + Convert.ToDouble(label6.Substring(11, 2)) + Convert.ToDouble(label6.Substring(14, 2)) / 100);

                    if (All == 0) All = 1;  //防止被除数为零导致程序崩溃
                    Double Progress = (Downloaded / All) * 100;

                    if (Progress > 100)  //防止进度条超过百分之百
                        Progress = 100;
                    if (Progress < 0)  //防止进度条小于零……
                        Progress = 0;

                    ProgressBar.Value = Convert.ToInt32(Progress);
                    windowsTaskbar.SetProgressValue(Convert.ToInt32(Progress), 100, this.Handle);
                    Application.DoEvents();
                    
                    this.Text = "[" + m_count.ToString() + " / " + m_urlList.Length.ToString() + "]" + "已完成：" +
                        String.Format("{0:F}", Progress) + "%";
                }
                catch (Exception)
                {
                    try
                    {
                        label5 = "[总时长：NULL]";
                        Double Downloaded = Convert.ToDouble(Convert.ToDouble(label6.Substring(5, 2)) * 60 * 60 + Convert.ToDouble(label6.Substring(8, 2)) * 60
                    + Convert.ToDouble(label6.Substring(11, 2)) + Convert.ToDouble(label6.Substring(14, 2)) / 100);
                        Double Progress = 100;

                        if (Progress > 100)  //防止进度条超过百分之百
                            Progress = 100;
                        if (Progress < 0)  //防止进度条小于零……
                            Progress = 0;

                        ProgressBar.Value = Convert.ToInt32(Progress);
                        windowsTaskbar.SetProgressValue(Convert.ToInt32(Progress), 100, this.Handle);
                        Application.DoEvents();

                        this.Text = "[" + m_count.ToString() + " / " + m_urlList.Length.ToString() + "]" + "已完成：" +
                        String.Format("{0:F}", Progress) + "%";
                    }
                    catch (Exception) { }
                }
            }
        }

        public void CreateSettingFile(string xmlPath)
        {
            XElement xElement = new XElement(
                new XElement("Settings",
                    new XElement("DownPath", m_path),
                    new XElement("EnableProxy",0),
                    new XElement("HttpProxy",m_proxy)
                ));

            //需要指定编码格式，否则在读取时会抛：根级别上的数据无效。 第 1 行 位置 1异常
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UTF8Encoding(false);
            settings.Indent = true;
            XmlWriter xw = XmlWriter.Create(xmlPath, settings);
            xElement.Save(xw);
            //写入文件
            xw.Flush();
            xw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////初始化进度条
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, this.Handle);
            windowsTaskbar.SetProgressValue(0, 100, this.Handle);
            toolTip1.SetToolTip(button_Stop, "发送停止指令，等待ffmpeg停止");
            toolTip1.SetToolTip(button_ForceStop, "直接终止ffmpeg进程");

            if (!File.Exists(@"Tools\ffmpeg.exe"))  //判断程序目录有无ffmpeg.exe
            {
                MessageBox.Show("没有找到Tools\\ffmpeg.exe" + Environment.NewLine + "Missing Tools\\ffmpeg.exe", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                Application.Exit();
            }

            if (File.Exists(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml"))  //判断程序目录有无配置文件，并读取文件
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml");    //加载Xml文件  
                m_path = doc.SelectSingleNode("//DownPath").InnerText;
                m_proxy = doc.SelectSingleNode("//HttpProxy").InnerText;
                int enableProxy = int.Parse(doc.SelectSingleNode("//EnableProxy").InnerText);
                if (enableProxy == 1)
                {
                    menu_Proxy.CheckState = CheckState.Checked;
                }
                else
                {
                    menu_Proxy.CheckState = CheckState.Unchecked;
                }
            }
            else  //若无配置文件，获取当前程序运行路径，即为默认下载路径
            {
                m_path = System.Environment.CurrentDirectory;
                m_proxy = "";

                CreateSettingFile(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml");
            }

        }

        private void textBox_Adress_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;
            if (e.KeyChar == (char)1)       // Ctrl-A 相当于输入了AscII=1的控制字符
            {
                textBox.SelectAll();
                e.Handled = true;      // 不再发出“噔”的声音
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml");    //加载Xml文件  
            int check = Convert.ToInt32(menu_Proxy.Checked);
            doc.SelectSingleNode("//EnableProxy").InnerText = check.ToString();
            doc.Save(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml");

            try
            {
                if (Process.GetProcessById(ffmpegid) != null)
                {
                    if (MessageBox.Show("已启动下载进程，确认退出吗？\n（这有可能是强制的）", "请确认您的操作", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Stop();
                        MessageBox.Show("已经发送命令！\n若进程仍然存在则强制结束！", "请确认");
                        try
                        {
                            if (Process.GetProcessById(ffmpegid) != null)  //如果进程还存在就强制结束它
                            {
                                Process.GetProcessById(ffmpegid).Kill();
                                Dispose();
                                Application.Exit();
                            }
                        }
                        catch
                        {
                            Dispose();
                            Application.Exit();
                        }

                    }
                    else
                    {
                        e.Cancel=true;
                    }
                }
            }
            catch
            {
                Dispose();
                Application.Exit();
            }
        }

        private void menu_Proxy_Click(object sender, EventArgs e)
        {
            if (m_proxy.Length == 0 )
            {
                MessageBox.Show("请设置代理后使用！" + Environment.NewLine + "Please select proxy!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu_Proxy.CheckState = CheckState.Unchecked;
                return;
            }
            if (!m_proxy.StartsWith("http://"))
            {
                MessageBox.Show("代理地址格式错误！" + Environment.NewLine + "Thge proxy address format is incorrect!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu_Proxy.CheckState = CheckState.Unchecked;
                return;
            }
            if (menu_Proxy.CheckState == CheckState.Unchecked)
            {
                menu_Proxy.CheckState = CheckState.Checked;
            }
            else
            {
                menu_Proxy.CheckState = CheckState.Unchecked;
            }
        }

        private void menu_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("magicdmer 编译于 2018/08/10\nCopyright ©  2018", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu_Set_Click(object sender, EventArgs e)
        {
            SetForm setDlg = new SetForm(CurrentLanguage);
            if (DialogResult.OK == setDlg.ShowDialog())
            {
                m_path = setDlg.m_path;
                m_proxy = setDlg.m_proxy;
            }
        }

        private void menu_FFmepg_Click(object sender, EventArgs e)
        {
            Process.Start("https://ffmpeg.zeranoe.com/builds/win32/static/");
        }

        private void button_ForceStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (Process.GetProcessById(ffmpegid) != null)  //如果进程还存在就强制结束它
                {
                    Process.GetProcessById(ffmpegid).Kill();
                }
            }
            catch { }
        }

        private void 软件更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/magicdmer/M3U8-Downloader");
        }

        private void button_OpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(m_path);
        }

        private void LanguageChinese_Click(object sender, EventArgs e)
        {
            ChangeLanguage("zh");
        }

        private void LanguageEnglish_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }



        private void ChangeLanguage(string languageCode)
        {
            CurrentLanguage = languageCode;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, new CultureInfo(languageCode));

                if (c is MenuStrip)
                {
                    foreach (ToolStripMenuItem menuitem in ((MenuStrip)c).Items)
                    {
                        resources.ApplyResources(menuitem, menuitem.Name, new CultureInfo(languageCode));

                        foreach (var submenuitem in ((ToolStripMenuItem)menuitem).DropDownItems)
                        {
                            if(submenuitem is ToolStripMenuItem)
                            {
                                resources.ApplyResources(submenuitem, ((ToolStripMenuItem)submenuitem).Name, new CultureInfo(languageCode));
                            }
                        }
                    }
                }
            }
        }
    }
}


namespace M3U8_Downloader
{
    // 1.定义委托  
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);

    public partial class Form1 : Form
    {
        // 2.定义委托事件  
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;
        
        private void button_Download_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(m_path))//若文件夹不存在则新建文件夹   
            {
                Directory.CreateDirectory(m_path); //新建文件夹   
            }

            if (textBox_Adress.Text.Length > 10)
            {
                m_outPut = "";
                textBox_forRegex.Text = "";
                ProgressBar.Value = 0;
                Application.DoEvents();
                label7.Visible = true;
                Download();
            }

        }

        string[] m_urlList;
        int m_count;
        string m_outPut;
        

        private void Download()
        {
            if (m_urlList != null)
            {
                MessageBox.Show("正在下载文件！" + Environment.NewLine + "Downloading file!", "M3U8 Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);  // 执行结束后触发
                return;
            }

            //这个地方如果用split，会出现间隔空元素的情况
            //m_urlList = textBox_Adress.Text.Split(Environment.NewLine.ToCharArray());
            m_urlList = Regex.Split(textBox_Adress.Text, Environment.NewLine, RegexOptions.IgnoreCase);
            m_count = 0;

            string command;
            if (menu_Proxy.Checked)
            {
                command = "-http_proxy " + m_proxy + " -rw_timeout 10000000 -i " + "\"" + m_urlList[0] + "\"" + " -c copy -y -bsf:a aac_adtstoasc -movflags +faststart " + "\"" + m_path + "\\" + textBox_Name.Text + m_count.ToString() + ".mp4" + "\"";
            }
            else
            {
                command = "-rw_timeout 10000000 -i " + "\"" + m_urlList[0] + "\"" + " -c copy -y -bsf:a aac_adtstoasc -movflags +faststart " + "\"" + m_path + "\\" + textBox_Name.Text + m_count.ToString() + ".mp4" + "\"";
            }

            // 启动进程执行相应命令,此例中以执行ffmpeg.exe为例  
            RealAction(@"Tools\ffmpeg.exe", command);
            m_count++;

        }

        private void RealAction(string StartFileName, string StartFileArg)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = StartFileArg;      // 参数  

            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
            //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            ffmpegid = CmdProcess.Id;//获取ffmpeg.exe的进程ID
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();

            // 如果打开注释，则以同步方式执行命令，则会卡死，不会捕获命令输出。此例子中用Exited事件异步执行。  
            //CmdProcess.WaitForExit();  
        }

        public void Stop()
        {
            AttachConsole(ffmpegid);
            SetConsoleCtrlHandler(IntPtr.Zero, true);
            GenerateConsoleCtrlEvent(0, 0);
            FreeConsole();
        }

        //以下为实现异步输出CMD信息

        private void Init()
        {
            //3.将相应函数注册到委托事件中  
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
        }

        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            textBox_forRegex.Text = result;
            m_outPut += (result + "\r\n");
            textBox_Info_TextChanged();
        }

        private void ReadErrOutputAction(string result)
        {
            textBox_forRegex.Text = result;
            m_outPut += (result + "\r\n");
            textBox_Info_TextChanged();
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            FlashWindow(this.Handle, true);

            if (m_count == m_urlList.Length)
            {
                m_urlList = null;
                this.Text = "M3U8 Downloader 2.0 by nilaoda & magicdmer";
                ProgressBar.Value = 100;
                windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, this.Handle);
                Application.DoEvents();
                MessageBox.Show("命令执行结束！", "M3U8 Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);  // 执行结束后触发
            }
            else
            {
                m_outPut = "";
                textBox_forRegex.Text = "";
                this.Text = "[" + (m_count+1).ToString() + "/" + m_urlList.Length.ToString() + "]" + "已完成：0%";
                ProgressBar.Value = 0;
                windowsTaskbar.SetProgressValue(0, 100, this.Handle);
                Application.DoEvents();

                string command;
                if (menu_Proxy.Checked)
                {
                    command = "-http_proxy " + m_proxy + " -rw_timeout 10000000 -i " + "\"" + m_urlList[m_count] + "\"" + " -c copy -y -bsf:a aac_adtstoasc -movflags +faststart " + "\"" + m_path + "\\" + textBox_Name.Text + m_count.ToString() + ".mp4" + "\"";
                }
                else
                {
                    command = "-rw_timeout 10000000 -i " + "\"" + m_urlList[m_count] + "\"" + " -c copy -y -bsf:a aac_adtstoasc -movflags +faststart " + "\"" + m_path + "\\" + textBox_Name.Text + m_count.ToString() + ".mp4" + "\"";
                }

                
                RealAction(@"Tools\ffmpeg.exe", command);

                m_count++;
            }
        }  
    }
}