using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Car_Spare_Parts_company
{
    public partial class Dashboard : Form
    {
      private UserControl uc1;
        
        public Dashboard(UserControl uc1)
        {
            InitializeComponent();
            showpanel(uc1);
            this.uc1 = uc1;

        }
        private void clickbtn(object sender)
        {
            Guna2Button Gunbtn = (Guna2Button)sender;
            pictureBox1.Location = new Point(Gunbtn.Location.X + 40,Gunbtn.Location.Y - 30);
            pictureBox1.SendToBack();
        }


        private void showpanel(UserControl uc)
        {
            panel2.Controls.Clear();
            panel2.Dock = DockStyle.Fill;
            uc.BringToFront();
            panel2.Controls.Add(uc);
        }



        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {

            clickbtn(sender);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hide();
            XtraForm1 fm = new XtraForm1();
            fm.ShowDialog();
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            showpanel(uc1);

        }
    }
}
