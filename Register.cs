using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Project_Kagisho_Phahlamohlaka_PRG252_OrderSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmpasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordConLable_Click(object sender, EventArgs e)
        {

            string message = "check The passwords again";
            MessageBox.Show(message);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (passwordTextBox1 == ConfirmpasswordTextBox)
                {

                    if (!string.IsNullOrEmpty(usernameTextBox1.Text) && !string.IsNullOrEmpty(passwordTextBox1.Text))
                    {
                        FileStream file = new FileStream("E:\\PRG252 files\\Project_PRG252_Kagisho_Phahlamohlaka\\Brand New\\usersCredentials.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        StreamWriter writer = new StreamWriter(file);
                        writer.WriteLine(usernameTextBox1.Text, userLevelComboBox.SelectedItem, passwordTextBox1.Text, ConfirmpasswordTextBox.Text);



                        StreamReader reader = new StreamReader(file);
                        if (usernameTextBox1.Text == usernameTextBox1.Text)
                        {
                            MessageBox.Show("This person already exists, use another name.");
                        }
                        else
                        {
                            MessageBox.Show("details have been added");
                            LoginForm login = new LoginForm();
                            login.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter username and passsword", "Register form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        usernameTextBox1.Focus();
                        usernameTextBox1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords missmatch error, Re-try");

                }

            }
            catch (Exception err)
            {
                MessageBox.Show($"Something went wrong{err.Message}");
               
            }
           
           

            
        }
    }
}
