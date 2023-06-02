using DevExpress.XtraEditors;
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
    public partial class FormEmployee : DevExpress.XtraEditors.XtraForm
    {

        Car_Company_DB datebase;
        Employee Emp;

        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            fir_Text_box.Text = "";
            Last_name_text_box.Text = "";
            salar_text_box.Text = "";
            phone_text_box.Text = "";
            Adderss_text_box.Text = "";
            ID_text_box.Text = "";
            Displaydata();
        }

        public void Displaydata()
        {
            datebase = new Car_Company_DB();
            gridControl1.DataSource = datebase.employees.Select(x => new { x.ID, x.FirstName, x.LastName, x.Salary, x.Phone, x.Adderss }).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            fir_Text_box.Text = gridView1.GetFocusedRowCellValue("FirstName").ToString();
            Last_name_text_box.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            salar_text_box.Text = gridView1.GetFocusedRowCellValue("Salary").ToString();
            phone_text_box.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            Adderss_text_box.Text = gridView1.GetFocusedRowCellValue("Adderss").ToString();
            ID_text_box.Text =gridView1.GetFocusedRowCellValue("ID").ToString();    
        }

        private void Add_data_Click(object sender, EventArgs e)

        {
            datebase = new Car_Company_DB();
            //int MyID = int.Parse(ID_text_box.Text);
            //var EmpId = datebase.employees.Where(x => x.ID == MyID).FirstOrDefault();
            if (fir_Text_box.Text == "" || Last_name_text_box.Text == "" || salar_text_box.Text == "" || phone_text_box.Text == ""
                || Adderss_text_box.Text == "")
            {
                MessageBox.Show("please inter Data");
            }
            //else if (EmpId != null)
            //{
            //   MessageBox.Show("not Add Employee");

            //    fir_Text_box.Text = "";
            //    Last_name_text_box.Text = "";
            //    salar_text_box.Text = "";
            //    phone_text_box.Text = "";
            //    Adderss_text_box.Text = "";
            //    ID_text_box.Text = "";
            //}
            else
            {
               
                Emp = new Employee();
                Emp.FirstName = fir_Text_box.Text;
                Emp.LastName = Last_name_text_box.Text;
                Emp.Salary = double.Parse(salar_text_box.Text);
                Emp.Phone = int.Parse(phone_text_box.Text);
                Emp.Adderss = Adderss_text_box.Text;
                datebase.employees.Add(Emp);
                datebase.SaveChanges();
                fir_Text_box.Text = "";
                Last_name_text_box.Text = "";
                salar_text_box.Text = "";
                phone_text_box.Text = "";
                Adderss_text_box.Text = "";
                ID_text_box.Text = "";
                Displaydata();

            }
        }

        private void update_data_Click(object sender, EventArgs e)
        {
            if (fir_Text_box.Text == "" || Last_name_text_box.Text == "" || salar_text_box.Text == "" || phone_text_box.Text == ""
                          || Adderss_text_box.Text == "")
            {
                MessageBox.Show("please inter Data");
            }
            else
            {
                Emp = new Employee();
                Emp.ID = int.Parse(ID_text_box.Text);
                Emp.FirstName = fir_Text_box.Text;
                Emp.LastName = Last_name_text_box.Text;
                Emp.Salary = double.Parse(salar_text_box.Text);
                Emp.Phone = int.Parse(phone_text_box.Text);
                Emp.Adderss = Adderss_text_box.Text;
                datebase.Entry(Emp).State =System.Data.Entity.EntityState.Modified;
                datebase.SaveChanges();
                fir_Text_box.Text = "";
                Last_name_text_box.Text = "";
                salar_text_box.Text = "";
                phone_text_box.Text = "";
                Adderss_text_box.Text = "";
                ID_text_box.Text = "";
                Displaydata();
            }
        }

        private void Delete_data_Click(object sender, EventArgs e)
        {
            if (fir_Text_box.Text == "" || Last_name_text_box.Text== "" || ID_text_box.Text == "" || salar_text_box.Text == "" || phone_text_box.Text == ""
         || Adderss_text_box.Text == "")
            {
                MessageBox.Show("Plase Select Data");
            }
            else
            {
                Emp = new Employee();
                Emp.ID = int.Parse(ID_text_box.Text);
                Emp.FirstName = fir_Text_box.Text;
                Emp.LastName = Last_name_text_box.Text;
                Emp.Salary = double.Parse(salar_text_box.Text);
                Emp.Phone = int.Parse(phone_text_box.Text);
                Emp.Adderss = Adderss_text_box.Text;
                datebase.Entry(Emp).State = System.Data.Entity.EntityState.Deleted;
                datebase.SaveChanges();
                fir_Text_box.Text = "";
                Last_name_text_box.Text = "";
                salar_text_box.Text = "";
                phone_text_box.Text = "";
                Adderss_text_box.Text = "";
                ID_text_box.Text = "";
                Displaydata();
            }
        }

        private void Clear_data_Click(object sender, EventArgs e)
        {
            fir_Text_box.Text = "";
            Last_name_text_box.Text = "";
            salar_text_box.Text = "";
            phone_text_box.Text = "";
            Adderss_text_box.Text = "";
            ID_text_box.Text = "";
        }
    }
}