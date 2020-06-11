namespace 重点用能数据上传
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.t_post = new System.Windows.Forms.TextBox();
            this.t_respond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // t_post
            // 
            this.t_post.Location = new System.Drawing.Point(12, 57);
            this.t_post.Multiline = true;
            this.t_post.Name = "t_post";
            this.t_post.Size = new System.Drawing.Size(414, 453);
            this.t_post.TabIndex = 1;
            // 
            // t_respond
            // 
            this.t_respond.Location = new System.Drawing.Point(432, 57);
            this.t_respond.Multiline = true;
            this.t_respond.Name = "t_respond";
            this.t_respond.Size = new System.Drawing.Size(414, 111);
            this.t_respond.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 640);
            this.Controls.Add(this.t_respond);
            this.Controls.Add(this.t_post);
            this.Controls.Add(this.button1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_post;
        private System.Windows.Forms.TextBox t_respond;
    }
}

