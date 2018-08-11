namespace M3U8_Downloader
{
    partial class SetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.button_Choose = new System.Windows.Forms.Button();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(82, 15);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(237, 23);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.WordWrap = false;
            // 
            // button_Choose
            // 
            this.button_Choose.Location = new System.Drawing.Point(325, 14);
            this.button_Choose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Choose.Name = "button_Choose";
            this.button_Choose.Size = new System.Drawing.Size(62, 26);
            this.button_Choose.TabIndex = 1;
            this.button_Choose.Text = "存储";
            this.button_Choose.UseVisualStyleBackColor = true;
            this.button_Choose.Click += new System.EventHandler(this.button_Choose_Click);
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.Location = new System.Drawing.Point(82, 58);
            this.textBoxProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.Size = new System.Drawing.Size(305, 23);
            this.textBoxProxy.TabIndex = 2;
            this.textBoxProxy.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "HTTP代理:";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(89, 96);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(82, 30);
            this.button_Ok.TabIndex = 4;
            this.button_Ok.Text = "确定";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(218, 96);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(88, 30);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "存储路径:";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProxy);
            this.Controls.Add(this.button_Choose);
            this.Controls.Add(this.textBoxPath);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button button_Choose;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}