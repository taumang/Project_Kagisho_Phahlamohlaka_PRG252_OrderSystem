namespace Project_Kagisho_Phahlamohlaka_PRG252_OrderSystem
{
    partial class Register
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
            this.UserNameLable = new System.Windows.Forms.Label();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ConfirmpasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserLevelLable = new System.Windows.Forms.Label();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordLable = new System.Windows.Forms.Label();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(12, 35);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(57, 13);
            this.UserNameLable.TabIndex = 0;
            this.UserNameLable.Text = "UserName";
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.Location = new System.Drawing.Point(128, 32);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(216, 20);
            this.usernameTextBox1.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(128, 238);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ConfirmpasswordTextBox
            // 
            this.ConfirmpasswordTextBox.Location = new System.Drawing.Point(128, 139);
            this.ConfirmpasswordTextBox.Name = "ConfirmpasswordTextBox";
            this.ConfirmpasswordTextBox.Size = new System.Drawing.Size(216, 20);
            this.ConfirmpasswordTextBox.TabIndex = 4;
            this.ConfirmpasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmpasswordTextBox_TextChanged);
            // 
            // UserLevelLable
            // 
            this.UserLevelLable.AutoSize = true;
            this.UserLevelLable.Location = new System.Drawing.Point(12, 203);
            this.UserLevelLable.Name = "UserLevelLable";
            this.UserLevelLable.Size = new System.Drawing.Size(55, 13);
            this.UserLevelLable.TabIndex = 3;
            this.UserLevelLable.Text = "UserLevel";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(128, 79);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(216, 20);
            this.passwordTextBox1.TabIndex = 6;
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(12, 86);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(53, 13);
            this.PasswordLable.TabIndex = 5;
            this.PasswordLable.Text = "Password";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(269, 238);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmPasswordLable
            // 
            this.ConfirmPasswordLable.AutoSize = true;
            this.ConfirmPasswordLable.Location = new System.Drawing.Point(12, 146);
            this.ConfirmPasswordLable.Name = "ConfirmPasswordLable";
            this.ConfirmPasswordLable.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPasswordLable.TabIndex = 8;
            this.ConfirmPasswordLable.Text = "Confirm Password";
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Items.AddRange(new object[] {
            "Admin",
            "Receptionist"});
            this.userLevelComboBox.Location = new System.Drawing.Point(128, 200);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(216, 21);
            this.userLevelComboBox.TabIndex = 9;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 278);
            this.Controls.Add(this.userLevelComboBox);
            this.Controls.Add(this.ConfirmPasswordLable);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.ConfirmpasswordTextBox);
            this.Controls.Add(this.UserLevelLable);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.usernameTextBox1);
            this.Controls.Add(this.UserNameLable);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox ConfirmpasswordTextBox;
        private System.Windows.Forms.Label UserLevelLable;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ConfirmPasswordLable;
        private System.Windows.Forms.ComboBox userLevelComboBox;
    }
}