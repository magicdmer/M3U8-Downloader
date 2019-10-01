using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace M3U8_Downloader
{
    public partial class SetForm : Form
    {
        public string m_path;
        public string m_proxy;

        public SetForm(string Language)
        {
            InitializeComponent();

            if(Language != "default")
            {
                ChangeLanguage(Language);
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            m_path = textBoxPath.Text;
            m_proxy = textBoxProxy.Text;

            XmlDocument doc = new XmlDocument();
            doc.Load(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml");    //加载Xml文件  
            doc.SelectSingleNode("//DownPath").InnerText = m_path;
            doc.SelectSingleNode("//HttpProxy").InnerText = m_proxy;
            doc.Save(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml");


            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            
            if (File.Exists(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml"))  //判断程序目录有无配置文件，并读取文件
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(System.Environment.CurrentDirectory + "\\M3u8_Downloader_Settings.xml");    //加载Xml文件  
                m_path = doc.SelectSingleNode("//DownPath").InnerText;
                m_proxy = doc.SelectSingleNode("//HttpProxy").InnerText;
            }
            else  //若无配置文件，获取当前程序运行路径，即为默认下载路径
            {
                m_path = System.Environment.CurrentDirectory;
                m_proxy = "";
            }

            textBoxPath.Text = m_path;
            textBoxProxy.Text = m_proxy;
        }


        private void button_Choose_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ChangeLanguage(string languageCode)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SetForm));
            resources.ApplyResources(this, this.Name, new CultureInfo(languageCode));

            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, new CultureInfo(languageCode));
            }
        }
    }
}
