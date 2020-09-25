namespace client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.Message = new System.Windows.Forms.TextBox();
            this.Send_message = new System.Windows.Forms.Button();
            this.Content_chat = new System.Windows.Forms.TextBox();
            this.chat_label = new System.Windows.Forms.Label();
            this.Connect_collect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Client_na = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.Connect_collect_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.Color.LavenderBlush;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Font = new System.Drawing.Font("宋体", 11F);
            this.Message.Location = new System.Drawing.Point(38, 480);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(511, 99);
            this.Message.TabIndex = 0;
            // 
            // Send_message
            // 
            this.Send_message.Location = new System.Drawing.Point(460, 585);
            this.Send_message.Name = "Send_message";
            this.Send_message.Size = new System.Drawing.Size(89, 40);
            this.Send_message.TabIndex = 1;
            this.Send_message.Text = "发送";
            this.Send_message.UseVisualStyleBackColor = true;
            this.Send_message.Click += new System.EventHandler(this.Send_message_Click);
            // 
            // Content_chat
            // 
            this.Content_chat.BackColor = System.Drawing.Color.LavenderBlush;
            this.Content_chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Content_chat.Font = new System.Drawing.Font("宋体", 11F);
            this.Content_chat.Location = new System.Drawing.Point(38, 142);
            this.Content_chat.Multiline = true;
            this.Content_chat.Name = "Content_chat";
            this.Content_chat.ReadOnly = true;
            this.Content_chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Content_chat.Size = new System.Drawing.Size(511, 276);
            this.Content_chat.TabIndex = 6;
            // 
            // chat_label
            // 
            this.chat_label.AutoSize = true;
            this.chat_label.BackColor = System.Drawing.Color.Transparent;
            this.chat_label.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chat_label.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.chat_label.Location = new System.Drawing.Point(33, 111);
            this.chat_label.Name = "chat_label";
            this.chat_label.Size = new System.Drawing.Size(96, 28);
            this.chat_label.TabIndex = 7;
            this.chat_label.Text = "聊天内容";
            // 
            // Connect_collect
            // 
            this.Connect_collect.AutoSize = true;
            this.Connect_collect.BackColor = System.Drawing.Color.Transparent;
            this.Connect_collect.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Connect_collect.ForeColor = System.Drawing.Color.HotPink;
            this.Connect_collect.Location = new System.Drawing.Point(640, 111);
            this.Connect_collect.Name = "Connect_collect";
            this.Connect_collect.Size = new System.Drawing.Size(96, 28);
            this.Connect_collect.TabIndex = 9;
            this.Connect_collect.Text = "连接情况";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(33, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "输入聊天内容";
            // 
            // Client_na
            // 
            this.Client_na.AutoSize = true;
            this.Client_na.BackColor = System.Drawing.Color.Transparent;
            this.Client_na.Font = new System.Drawing.Font("宋体", 25F);
            this.Client_na.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Client_na.Location = new System.Drawing.Point(36, 38);
            this.Client_na.Name = "Client_na";
            this.Client_na.Size = new System.Drawing.Size(202, 34);
            this.Client_na.TabIndex = 11;
            this.Client_na.Text = "           ";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(38, 585);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(89, 40);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "退出";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Connect_collect_text
            // 
            this.Connect_collect_text.BackColor = System.Drawing.Color.LavenderBlush;
            this.Connect_collect_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Connect_collect_text.Font = new System.Drawing.Font("宋体", 11F);
            this.Connect_collect_text.Location = new System.Drawing.Point(645, 142);
            this.Connect_collect_text.Multiline = true;
            this.Connect_collect_text.Name = "Connect_collect_text";
            this.Connect_collect_text.ReadOnly = true;
            this.Connect_collect_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Connect_collect_text.Size = new System.Drawing.Size(281, 437);
            this.Connect_collect_text.TabIndex = 8;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 679);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Client_na);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_collect);
            this.Controls.Add(this.Connect_collect_text);
            this.Controls.Add(this.chat_label);
            this.Controls.Add(this.Content_chat);
            this.Controls.Add(this.Send_message);
            this.Controls.Add(this.Message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button Send_message;
        private System.Windows.Forms.TextBox Content_chat;
        private System.Windows.Forms.Label chat_label;
        private System.Windows.Forms.Label Connect_collect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Client_na;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.TextBox Connect_collect_text;
    }
}

