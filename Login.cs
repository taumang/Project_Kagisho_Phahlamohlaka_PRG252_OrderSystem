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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameTextBox2.Select();
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("E:\\PRG252 files\\Project_PRG252_Kagisho_Phahlamohlaka\\Brand New\\usersCredentials.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);

            if (File.Exists("E:\\PRG252 files\\Project_PRG252_Kagisho_Phahlamohlaka\\Brand New\\usersCredentials.txt"))
            {
               
                string Line = "";
                while ((Line = reader.ReadLine()) != null)
                {
                    MessageBox.Show("Your Logged in");

                    MainForm TheMainOne = new MainForm();
                    TheMainOne.ShowDialog();
                    reader.Close();
                    file.Close();
                }

            }
        }
    }
}
