namespace client
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.Nickname = new System.Windows.Forms.TextBox();
            this.IP_address = new System.Windows.Forms.TextBox();
            this.Nickname_label = new System.Windows.Forms.Label();
            this.IP_address_label = new System.Windows.Forms.Label();
            this.Log_in_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nickname
            // 
            this.Nickname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Nickname.Location = new System.Drawing.Point(32, 42);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(314, 21);
            this.Nickname.TabIndex = 0;
            // 
            // IP_address
            // 
            this.IP_address.BackColor = System.Drawing.SystemColors.Window;
            this.IP_address.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IP_address.Location = new System.Drawing.Point(32, 119);
            this.IP_address.Name = "IP_address";
            this.IP_address.Size = new System.Drawing.Size(314, 21);
            this.IP_address.TabIndex = 1;
            // 
            // Nickname_label
            // 
            this.Nickname_label.AutoSize = true;
            this.Nickname_label.Location = new System.Drawing.Point(30, 27);
            this.Nickname_label.Name = "Nickname_label";
            this.Nickname_label.Size = new System.Drawing.Size(29, 12);
            this.Nickname_label.TabIndex = 2;
            this.Nickname_label.Text = "昵称";
            // 
            // IP_address_label
            // 
            this.IP_address_label.AutoSize = true;
            this.IP_address_label.Location = new System.Drawing.Point(30, 104);
            this.IP_address_label.Name = "IP_address_label";
            this.IP_address_label.Size = new System.Drawing.Size(41, 12);
            this.IP_address_label.TabIndex = 3;
            this.IP_address_label.Text = "IP地址";
            // 
            // Log_in_btn
            // 
            this.Log_in_btn.Location = new System.Drawing.Point(32, 181);
            this.Log_in_btn.Name = "Log_in_btn";
            this.Log_in_btn.Size = new System.Drawing.Size(314, 23);
            this.Log_in_btn.TabIndex = 4;
            this.Log_in_btn.Text = "登录";
            this.Log_in_btn.UseVisualStyleBackColor = true;
            this.Log_in_btn.Click += new System.EventHandler(this.Log_in_btn_Click);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 247);
            this.Controls.Add(this.Log_in_btn);
            this.Controls.Add(this.IP_address_label);
            this.Controls.Add(this.Nickname_label);
            this.Controls.Add(this.IP_address);
            this.Controls.Add(this.Nickname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_in";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.TextBox IP_address;
        private System.Windows.Forms.Label Nickname_label;
        private System.Windows.Forms.Label IP_address_label;
        private System.Windows.Forms.Button Log_in_btn;
    }
}