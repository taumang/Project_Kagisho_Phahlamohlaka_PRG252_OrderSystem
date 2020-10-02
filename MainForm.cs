using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kagisho_Phahlamohlaka_PRG252_OrderSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderform insert = new Orderform();
            insert.ShowDialog();
        }
    }
}
