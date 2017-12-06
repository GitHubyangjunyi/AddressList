namespace 通讯录
{
    partial class Login
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
            this.linkLabel_sign_up = new System.Windows.Forms.LinkLabel();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_pwd = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.checkBox_ = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel_sign_up
            // 
            this.linkLabel_sign_up.AutoSize = true;
            this.linkLabel_sign_up.Location = new System.Drawing.Point(415, 129);
            this.linkLabel_sign_up.Name = "linkLabel_sign_up";
            this.linkLabel_sign_up.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_sign_up.TabIndex = 13;
            this.linkLabel_sign_up.TabStop = true;
            this.linkLabel_sign_up.Text = "注册";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(368, 75);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(129, 21);
            this.textBox_pwd.TabIndex = 11;
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_username.Location = new System.Drawing.Point(368, 32);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(129, 21);
            this.textBox_username.TabIndex = 12;
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Font = new System.Drawing.Font("宋体", 12F);
            this.label_pwd.Location = new System.Drawing.Point(281, 75);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(48, 16);
            this.label_pwd.TabIndex = 9;
            this.label_pwd.Text = "密码:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("宋体", 12F);
            this.label_username.Location = new System.Drawing.Point(267, 37);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(64, 16);
            this.label_username.TabIndex = 10;
            this.label_username.Text = "用户名:";
            // 
            // checkBox_
            // 
            this.checkBox_.AutoSize = true;
            this.checkBox_.Location = new System.Drawing.Point(321, 129);
            this.checkBox_.Name = "checkBox_";
            this.checkBox_.Size = new System.Drawing.Size(72, 16);
            this.checkBox_.TabIndex = 8;
            this.checkBox_.Text = "记住密码";
            this.checkBox_.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_sign_in
            // 
            this.bt_sign_in.Location = new System.Drawing.Point(283, 209);
            this.bt_sign_in.Name = "bt_sign_in";
            this.bt_sign_in.Size = new System.Drawing.Size(75, 46);
            this.bt_sign_in.TabIndex = 6;
            this.bt_sign_in.Text = "登录";
            this.bt_sign_in.UseVisualStyleBackColor = true;
            this.bt_sign_in.Click += new System.EventHandler(this.bt_sign_in_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.linkLabel_sign_up);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.checkBox_);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_sign_in);
            this.Name = "Login";
            this.Text = "通讯录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_sign_up;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.CheckBox checkBox_;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_sign_in;
    }
}

