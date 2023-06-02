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
    public partial class ForgetPassword : Form
    {
        private Car_Company_DB fb;
        public ForgetPassword()
        {
            InitializeComponent();
            fb = new Car_Company_DB();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int res=0;
            
            if (guna2TextBox3.TextLength > 0 && guna2TextBox4.TextLength > 0 && guna2TextBox1.TextLength > 0)
            {
                if (int.TryParse(guna2TextBox3.Text, out res))
                {


                    if (fb.Users.Any(r => r.username == guna2TextBox4.Text) && fb.Users.Any(r => r.MobileNO == res))
                    {
                        try
                        {
                            var result = fb.Users.Where(r => r.username == guna2TextBox4.Text && r.MobileNO == res).FirstOrDefault();
                            result.Password = guna2TextBox1.Text;
                            fb.SaveChanges();
                            MessageBox.Show("updated succesefully");

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("password should br minimum 6 charcters ya 3rs");
                        }
                       
                        

                    }
                    else
                    {
                        MessageBox.Show("invalid credintials");
                    }
                }
                else
                {
                    MessageBox.Show("mobile number invalid");
                }
            }
            else
            {
                MessageBox.Show(" you have to fill the data");
            }
        }
    }
}
