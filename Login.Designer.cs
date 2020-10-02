namespace Project_Kagisho_Phahlamohlaka_PRG252_OrderSystem
{
    partial class LoginForm
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
            this.userLevelComboBox2 = new System.Windows.Forms.ComboBox();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.UserLevelLable = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.usernameTextBox2 = new System.Windows.Forms.TextBox();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.RegisterLinkLable = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userLevelComboBox2
            // 
            this.userLevelComboBox2.FormattingEnabled = true;
            this.userLevelComboBox2.Items.AddRange(new object[] {
            "Admin",
            "Receptionist"});
            this.userLevelComboBox2.Location = new System.Drawing.Point(144, 144);
            this.userLevelComboBox2.Name = "userLevelComboBox2";
            this.userLevelComboBox2.Size = new System.Drawing.Size(216, 21);
            this.userLevelComboBox2.TabIndex = 19;
            // 
            // CancelButton2
            // 
            this.CancelButton2.Location = new System.Drawing.Point(285, 192);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(75, 23);
            this.CancelButton2.TabIndex = 17;
            this.CancelButton2.Text = "Cancel";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.CancelButton2_Click);
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(144, 91);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.Size = new System.Drawing.Size(216, 20);
            this.passwordTextBox2.TabIndex = 16;
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(28, 98);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(53, 13);
            this.PasswordLable.TabIndex = 15;
            this.PasswordLable.Text = "Password";
            // 
            // UserLevelLable
            // 
            this.UserLevelLable.AutoSize = true;
            this.UserLevelLable.Location = new System.Drawing.Point(28, 152);
            this.UserLevelLable.Name = "UserLevelLable";
            this.UserLevelLable.Size = new System.Drawing.Size(55, 13);
            this.UserLevelLable.TabIndex = 13;
            this.UserLevelLable.Text = "UserLevel";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(144, 192);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // usernameTextBox2
            // 
            this.usernameTextBox2.Location = new System.Drawing.Point(144, 44);
            this.usernameTextBox2.Name = "usernameTextBox2";
            this.usernameTextBox2.Size = new System.Drawing.Size(216, 20);
            this.usernameTextBox2.TabIndex = 11;
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(28, 51);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(57, 13);
            this.UserNameLable.TabIndex = 10;
            this.UserNameLable.Text = "UserName";
            // 
            // RegisterLinkLable
            // 
            this.RegisterLinkLable.AutoSize = true;
            this.RegisterLinkLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLinkLable.Location = new System.Drawing.Point(105, 237);
            this.RegisterLinkLable.Name = "RegisterLinkLable";
            this.RegisterLinkLable.Size = new System.Drawing.Size(153, 20);
            this.RegisterLinkLable.TabIndex = 20;
            this.RegisterLinkLable.TabStop = true;
            this.RegisterLinkLable.Text = "New?, Lets Sign Up ";
            this.RegisterLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLable_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 266);
            this.Controls.Add(this.RegisterLinkLable);
            this.Controls.Add(this.userLevelComboBox2);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UserLevelLable);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.usernameTextBox2);
            this.Controls.Add(this.UserNameLable);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userLevelComboBox2;
        private System.Windows.Forms.Button CancelButton2;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label UserLevelLable;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox usernameTextBox2;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.LinkLabel RegisterLinkLable;
    }
}

