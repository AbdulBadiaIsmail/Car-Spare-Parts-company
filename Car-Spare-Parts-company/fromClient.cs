using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Spare_Parts_company
{
    public partial class fromClient : DevExpress.XtraEditors.XtraForm
    {

        Client MyClient;
        Car_Company_DB datebase;
        public fromClient()
        {
            InitializeComponent();
        }

        private void fromClient_Load(object sender, EventArgs e)
        {

            text_ID.Text = "";
            Name_text.Text = "";
            Displaygridview();

        }

        public void Displaygridview()
        {
            datebase = new Car_Company_DB();
            gridControl1.DataSource = datebase.Clients.Select(x => new { x.ID, x.Name }).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            text_ID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            Name_text.Text = gridView1.GetFocusedRowCellValue("Name").ToString();   
        }

        private void Clear_from_Click(object sender, EventArgs e)
        {
            text_ID.Text = "";
            Name_text.Text = "";
        }

        private void Add_client_Click(object sender, EventArgs e)
        {
            try
            {
                datebase = new Car_Company_DB();
                MyClient = new Client();
                string name = Name_text.Text;
                var clientName = datebase.Clients.Where(x => x.Name == name).FirstOrDefault();
                if (Name_text.Text == "")
                {
                    MessageBox.Show("please inter Name");
                }
                else if (clientName != null)
                {
                    MessageBox.Show("Can not Add ");
                }
                else
                {
                    MyClient.Name = Name_text.Text;
                    datebase.Clients.Add(MyClient);
                    datebase.SaveChanges();
                    Displaygridview();
                    Name_text.Text = "";
                    text_ID.Text = "";
                }
            }
            catch (Exception M)
            {
                MessageBox.Show(M.Message);
            }
        }

        private void Update_Client_Click(object sender, EventArgs e)
        {
            try
            {
                datebase = new Car_Company_DB();
                MyClient = new Client();
                string n = Name_text.Text;
                var name = datebase.Clients.Select(x => x.Name).FirstOrDefault();
                if (text_ID.Text == "" || Name_text.Text == "")
                {
                    MessageBox.Show("pleas Slect Row ");
                }
                else if (name == n)
                {
                    MessageBox.Show("pleas Edit data ");
                }
                else
                {
                    MyClient.ID = int.Parse(text_ID.Text);
                    MyClient.Name = Name_text.Text;
                    datebase.Entry(MyClient).State = EntityState.Modified;
                    datebase.SaveChanges();
                    Displaygridview();
                    Name_text.Text = " ";
                    text_ID.Text = " ";

                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void Delete_Client_Click(object sender, EventArgs e)
        {
            try
            {
                MyClient = new Client();
                datebase = new Car_Company_DB();
                if (text_ID.Text == "" || Name_text.Text == "")
                {
                    MessageBox.Show("pleas Slect Row ");
                }
                else
                {
                    MyClient.ID = int.Parse(text_ID.Text);
                    MyClient.Name = Name_text.Text;
                    datebase.Entry(MyClient).State = EntityState.Deleted;
                    datebase.SaveChanges();
                    Displaygridview();
                    Name_text.Text = "";
                    text_ID.Text = "";
                }

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }
    }
}