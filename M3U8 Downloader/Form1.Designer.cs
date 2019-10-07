using System;

namespace M3U8_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Download = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_forRegex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Proxy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.软件更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_FFmpeg = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageChinese = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.button_ForceStop = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_OpenFolder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Download
            // 
            resources.ApplyResources(this.button_Download, "button_Download");
            this.button_Download.BackColor = System.Drawing.Color.Silver;
            this.button_Download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Download.FlatAppearance.BorderSize = 0;
            this.button_Download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_Download.ForeColor = System.Drawing.Color.White;
            this.button_Download.Name = "button_Download";
            this.toolTip1.SetToolTip(this.button_Download, resources.GetString("button_Download.ToolTip"));
            this.button_Download.UseVisualStyleBackColor = false;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // button_Stop
            // 
            resources.ApplyResources(this.button_Stop, "button_Stop");
            this.button_Stop.BackColor = System.Drawing.Color.Silver;
            this.button_Stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Stop.FlatAppearance.BorderSize = 0;
            this.button_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_Stop.ForeColor = System.Drawing.Color.White;
            this.button_Stop.Name = "button_Stop";
            this.toolTip1.SetToolTip(this.button_Stop, resources.GetString("button_Stop.ToolTip"));
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // textBox_Adress
            // 
            resources.ApplyResources(this.textBox_Adress, "textBox_Adress");
            this.textBox_Adress.BackColor = System.Drawing.Color.White;
            this.textBox_Adress.ForeColor = System.Drawing.Color.Black;
            this.textBox_Adress.Name = "textBox_Adress";
            this.toolTip1.SetToolTip(this.textBox_Adress, resources.GetString("textBox_Adress.ToolTip"));
            // 
            // textBox_Name
            // 
            resources.ApplyResources(this.textBox_Name, "textBox_Name");
            this.textBox_Name.BackColor = System.Drawing.Color.White;
            this.textBox_Name.ForeColor = System.Drawing.Color.Black;
            this.textBox_Name.Name = "textBox_Name";
            this.toolTip1.SetToolTip(this.textBox_Name, resources.GetString("textBox_Name.ToolTip"));
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // textBox_forRegex
            // 
            resources.ApplyResources(this.textBox_forRegex, "textBox_forRegex");
            this.textBox_forRegex.Name = "textBox_forRegex";
            this.toolTip1.SetToolTip(this.textBox_forRegex, resources.GetString("textBox_forRegex.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // 工具TToolStripMenuItem
            // 
            resources.ApplyResources(this.工具TToolStripMenuItem, "工具TToolStripMenuItem");
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Proxy,
            this.menu_Set});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            // 
            // menu_Proxy
            // 
            resources.ApplyResources(this.menu_Proxy, "menu_Proxy");
            this.menu_Proxy.Name = "menu_Proxy";
            this.menu_Proxy.Click += new System.EventHandler(this.menu_Proxy_Click);
            // 
            // menu_Set
            // 
            resources.ApplyResources(this.menu_Set, "menu_Set");
            this.menu_Set.Name = "menu_Set";
            this.menu_Set.Click += new System.EventHandler(this.menu_Set_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            resources.ApplyResources(this.帮助HToolStripMenuItem, "帮助HToolStripMenuItem");
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.软件更新ToolStripMenuItem,
            this.menu_FFmpeg,
            this.LanguageMenu,
            this.menu_About});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // 软件更新ToolStripMenuItem
            // 
            resources.ApplyResources(this.软件更新ToolStripMenuItem, "软件更新ToolStripMenuItem");
            this.软件更新ToolStripMenuItem.Name = "软件更新ToolStripMenuItem";
            this.软件更新ToolStripMenuItem.Click += new System.EventHandler(this.软件更新ToolStripMenuItem_Click);
            // 
            // menu_FFmpeg
            // 
            resources.ApplyResources(this.menu_FFmpeg, "menu_FFmpeg");
            this.menu_FFmpeg.Name = "menu_FFmpeg";
            this.menu_FFmpeg.Click += new System.EventHandler(this.menu_FFmepg_Click);
            // 
            // LanguageMenu
            // 
            resources.ApplyResources(this.LanguageMenu, "LanguageMenu");
            this.LanguageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageChinese,
            this.LanguageEnglish});
            this.LanguageMenu.Name = "LanguageMenu";
            // 
            // LanguageChinese
            // 
            resources.ApplyResources(this.LanguageChinese, "LanguageChinese");
            this.LanguageChinese.Name = "LanguageChinese";
            this.LanguageChinese.Click += new System.EventHandler(this.LanguageChinese_Click);
            // 
            // LanguageEnglish
            // 
            resources.ApplyResources(this.LanguageEnglish, "LanguageEnglish");
            this.LanguageEnglish.Name = "LanguageEnglish";
            this.LanguageEnglish.Click += new System.EventHandler(this.LanguageEnglish_Click);
            // 
            // menu_About
            // 
            resources.ApplyResources(this.menu_About, "menu_About");
            this.menu_About.Name = "menu_About";
            this.menu_About.Click += new System.EventHandler(this.menu_About_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // ProgressBar
            // 
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Step = 1;
            this.toolTip1.SetToolTip(this.ProgressBar, resources.GetString("ProgressBar.ToolTip"));
            // 
            // button_ForceStop
            // 
            resources.ApplyResources(this.button_ForceStop, "button_ForceStop");
            this.button_ForceStop.Name = "button_ForceStop";
            this.toolTip1.SetToolTip(this.button_ForceStop, resources.GetString("button_ForceStop.ToolTip"));
            this.button_ForceStop.UseVisualStyleBackColor = true;
            this.button_ForceStop.Click += new System.EventHandler(this.button_ForceStop_Click);
            // 
            // button_OpenFolder
            // 
            resources.ApplyResources(this.button_OpenFolder, "button_OpenFolder");
            this.button_OpenFolder.Name = "button_OpenFolder";
            this.toolTip1.SetToolTip(this.button_OpenFolder, resources.GetString("button_OpenFolder.ToolTip"));
            this.button_OpenFolder.UseVisualStyleBackColor = true;
            this.button_OpenFolder.Click += new System.EventHandler(this.button_OpenFolder_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.button_OpenFolder);
            this.Controls.Add(this.button_ForceStop);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_forRegex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_forRegex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Proxy;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
        private System.Windows.Forms.ToolStripMenuItem menu_Set;
        private System.Windows.Forms.ToolStripMenuItem 软件更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_FFmpeg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button button_ForceStop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_OpenFolder;
        private System.Windows.Forms.ToolStripMenuItem LanguageMenu;
        private System.Windows.Forms.ToolStripMenuItem LanguageChinese;
        private System.Windows.Forms.ToolStripMenuItem LanguageEnglish;
    }
}

