using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegister
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PnlUserName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnlRegister.Height =PnlMain.Height;
            PnlMain.Location = new Point(5,5);
            Pnl.Location = new Point(385,5);
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0;
            PnlMain.Location = new Point(315,5);
            Pnl.Location = new Point(5,5);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
        }

       

        private void BtnMainClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
