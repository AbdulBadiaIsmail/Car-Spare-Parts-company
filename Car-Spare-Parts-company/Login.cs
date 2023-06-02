using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Spare_Parts_company
{
    public partial class Login : Form
    {
        private Car_Company_DB db;
        public Login()
        {
            InitializeComponent();
             db = new Car_Company_DB();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.TextLength>0 && guna2TextBox4.TextLength > 0)
            {
                if (db.Users.Any(r => r.username == guna2TextBox4.Text) && db.Users.Any(r => r.Password == guna2TextBox3.Text))
                {
                    var empType = db.Users.Where(r => r.username == guna2TextBox4.Text && r.Password == guna2TextBox3.Text).SingleOrDefault().type;
                    Hide();
                    if (empType== "employee")
                    {
                       
                        Dashboard dh = new Dashboard(new UserControl1());
                        dh.ShowDialog();
                       
                    }
                    else
                    {
                        Dashboard dh = new Dashboard(new HRusercontrol());
                        dh.ShowDialog();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("not found");
                } 
            }
            else
            {
                MessageBox.Show(" you have to fill the data");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.ShowDialog();
        }
    }
}
