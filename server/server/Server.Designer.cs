namespace server
{
    partial class server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(server));
            this.Connection = new System.Windows.Forms.TextBox();
            this.Connection_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Font = new System.Drawing.Font("宋体", 11F);
            this.Connection.Location = new System.Drawing.Point(17, 53);
            this.Connection.Multiline = true;
            this.Connection.Name = "Connection";
            this.Connection.ReadOnly = true;
            this.Connection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Connection.Size = new System.Drawing.Size(455, 373);
            this.Connection.TabIndex = 0;
            // 
            // Connection_label
            // 
            this.Connection_label.AutoSize = true;
            this.Connection_label.BackColor = System.Drawing.Color.Transparent;
            this.Connection_label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Connection_label.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Connection_label.Location = new System.Drawing.Point(12, 22);
            this.Connection_label.Name = "Connection_label";
            this.Connection_label.Size = new System.Drawing.Size(96, 28);
            this.Connection_label.TabIndex = 1;
            this.Connection_label.Text = "连接状况";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("宋体", 12F);
            this.exit_button.Location = new System.Drawing.Point(591, 364);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(107, 62);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "退出服务器";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("宋体", 12F);
            this.Start.Location = new System.Drawing.Point(478, 364);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 62);
            this.Start.TabIndex = 3;
            this.Start.Text = "开启服务器";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 454);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Connection_label);
            this.Controls.Add(this.Connection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "server";
            this.Text = "服务器";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Connection;
        private System.Windows.Forms.Label Connection_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button Start;
    }
}

