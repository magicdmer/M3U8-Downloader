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
            this.button_Download.BackColor = System.Drawing.Color.Silver;
            this.button_Download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Download.FlatAppearance.BorderSize = 0;
            this.button_Download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_Download.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Download.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Download.ForeColor = System.Drawing.Color.White;
            this.button_Download.Location = new System.Drawing.Point(36, 353);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(78, 39);
            this.button_Download.TabIndex = 11;
            this.button_Download.Text = "下载";
            this.button_Download.UseVisualStyleBackColor = false;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.Silver;
            this.button_Stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Stop.FlatAppearance.BorderSize = 0;
            this.button_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Stop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Stop.ForeColor = System.Drawing.Color.White;
            this.button_Stop.Location = new System.Drawing.Point(153, 353);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(78, 39);
            this.button_Stop.TabIndex = 12;
            this.button_Stop.Text = "停止";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "下载地址（批量请换行）";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.BackColor = System.Drawing.Color.White;
            this.textBox_Adress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Adress.ForeColor = System.Drawing.Color.Black;
            this.textBox_Adress.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_Adress.Location = new System.Drawing.Point(12, 36);
            this.textBox_Adress.Multiline = true;
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Adress.Size = new System.Drawing.Size(496, 211);
            this.textBox_Adress.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.White;
            this.textBox_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Name.ForeColor = System.Drawing.Color.Black;
            this.textBox_Name.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_Name.Location = new System.Drawing.Point(12, 276);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(496, 23);
            this.textBox_Name.TabIndex = 7;
            this.textBox_Name.Text = "Video";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(216, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "[视频信息，]";
            this.label7.Visible = false;
            // 
            // textBox_forRegex
            // 
            this.textBox_forRegex.Location = new System.Drawing.Point(909, 307);
            this.textBox_forRegex.Name = "textBox_forRegex";
            this.textBox_forRegex.Size = new System.Drawing.Size(24, 21);
            this.textBox_forRegex.TabIndex = 114;
            this.textBox_forRegex.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(935, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 115;
            this.label8.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(399, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(119, 24);
            this.menuStrip1.TabIndex = 116;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Proxy,
            this.menu_Set});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // menu_Proxy
            // 
            this.menu_Proxy.Name = "menu_Proxy";
            this.menu_Proxy.Size = new System.Drawing.Size(98, 22);
            this.menu_Proxy.Text = "代理";
            this.menu_Proxy.Click += new System.EventHandler(this.menu_Proxy_Click);
            // 
            // menu_Set
            // 
            this.menu_Set.Name = "menu_Set";
            this.menu_Set.Size = new System.Drawing.Size(98, 22);
            this.menu_Set.Text = "设置";
            this.menu_Set.Click += new System.EventHandler(this.menu_Set_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.软件更新ToolStripMenuItem,
            this.menu_FFmpeg,
            this.menu_About});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // 软件更新ToolStripMenuItem
            // 
            this.软件更新ToolStripMenuItem.Name = "软件更新ToolStripMenuItem";
            this.软件更新ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.软件更新ToolStripMenuItem.Text = "软件更新";
            this.软件更新ToolStripMenuItem.Click += new System.EventHandler(this.软件更新ToolStripMenuItem_Click);
            // 
            // menu_FFmpeg
            // 
            this.menu_FFmpeg.Name = "menu_FFmpeg";
            this.menu_FFmpeg.Size = new System.Drawing.Size(122, 22);
            this.menu_FFmpeg.Text = "FFMPEG";
            this.menu_FFmpeg.Click += new System.EventHandler(this.menu_FFmepg_Click);
            // 
            // menu_About
            // 
            this.menu_About.Name = "menu_About";
            this.menu_About.Size = new System.Drawing.Size(122, 22);
            this.menu_About.Text = "关于(&A)...";
            this.menu_About.Click += new System.EventHandler(this.menu_About_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 117;
            this.label2.Text = "文件名前缀（video0.mp4,Video1.mp4...）";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 315);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(496, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 118;
            // 
            // button_ForceStop
            // 
            this.button_ForceStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ForceStop.Location = new System.Drawing.Point(276, 353);
            this.button_ForceStop.Name = "button_ForceStop";
            this.button_ForceStop.Size = new System.Drawing.Size(78, 39);
            this.button_ForceStop.TabIndex = 119;
            this.button_ForceStop.Text = "强制停止";
            this.button_ForceStop.UseVisualStyleBackColor = true;
            this.button_ForceStop.Click += new System.EventHandler(this.button_ForceStop_Click);
            // 
            // button_OpenFolder
            // 
            this.button_OpenFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenFolder.Location = new System.Drawing.Point(399, 353);
            this.button_OpenFolder.Name = "button_OpenFolder";
            this.button_OpenFolder.Size = new System.Drawing.Size(75, 39);
            this.button_OpenFolder.TabIndex = 120;
            this.button_OpenFolder.Text = "打开目录";
            this.button_OpenFolder.UseVisualStyleBackColor = true;
            this.button_OpenFolder.Click += new System.EventHandler(this.button_OpenFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(520, 401);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M3U8 Downloader 2.0 by magicdmer";
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
    }
}

