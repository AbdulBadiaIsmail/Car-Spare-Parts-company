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
    public partial class Employeess : DevExpress.XtraEditors.XtraForm
    {
       Car_Company_DB dbcontent;
        Employee Emp;
        public Employeess()
        {
            InitializeComponent();
        }

        private void Employeess_Load(object sender, EventArgs e)
        {
                
            First_name_text.Text = "";
            Ls_text.Text = "";
            Salary_text.Text = "";
            phone_text.Text = "";
            Adders_text.Text = "";
            ID_text.Text = "";
            GrideEmployee();
           
        }

        public void GrideEmployee()
        {
            dbcontent = new Car_Company_DB();
            gridControl1.DataSource = dbcontent.employees.Select(x=>new {x.ID,x.FirstName,x.LastName, x.Salary,x.Phone,x.Adderss}).ToList();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            First_name_text.Text = gridView1.GetFocusedRowCellValue("FirstName").ToString();
            Ls_text.Text = gridView1.GetFocusedRowCellValue("LastName").ToString();
            Salary_text.Text = gridView1.GetFocusedRowCellValue("Salary").ToString();
            phone_text.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            Adders_text.Text = gridView1.GetFocusedRowCellValue("Adderss").ToString();
            ID_text.Text = gridView1.GetFocusedRowCellValue("ID").ToString();

        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            //int MyID = int.Parse(ID_text.Text);
            //var EmpId = dbcontent.employees.Where(x => x.ID == MyID).FirstOrDefault();
            if (First_name_text.Text=="" ||Ls_text.Text ==""|| Salary_text.Text ==""|| phone_text.Text==""
                ||Adders_text.Text =="")
            {
                MessageBox.Show("please inter Data");
            }
            //else if (EmpId != null)
            //{
            //    MessageBox.Show("not Add Employee");
            //}
            else
            {
                dbcontent = new Car_Company_DB();
                Emp = new Employee();
                Emp.FirstName = First_name_text.Text;  
                Emp.LastName = First_name_text.Text;
                Emp.Salary = double.Parse(Salary_text.Text);
                Emp.Phone = int.Parse(phone_text.Text);
                Emp.Adderss = Adders_text.Text;
                dbcontent.employees.Add(Emp);   
                dbcontent.SaveChanges();
                First_name_text.Text = "";
                Ls_text.Text = "";
                Salary_text.Text = "";
                phone_text.Text = "";
                Adders_text.Text = "";
                ID_text.Text = "";
                GrideEmployee();

            }
        }

        private void Upd_Employee_Click(object sender, EventArgs e)

        {
            
            if (First_name_text.Text == "" || Ls_text.Text == "" || ID_text.Text == "" || Salary_text.Text == "" || phone_text.Text == ""
              || Adders_text.Text == "")
            {
                MessageBox.Show("please inter Data");
            }
  
            else
            {
                dbcontent = new Car_Company_DB();
                Emp = new Employee();
                Emp.ID = int.Parse(ID_text.Text);
                Emp.FirstName = First_name_text.Text;
                Emp.LastName = First_name_text.Text;
                Emp.Salary = double.Parse(Salary_text.Text);
                Emp.Phone = int.Parse(phone_text.Text);
                Emp.Adderss = Adders_text.Text;
                dbcontent.Entry(Emp).State = System.Data.Entity.EntityState.Modified;
                dbcontent.SaveChanges();

                First_name_text.Text = "";
                Ls_text.Text = "";
                Salary_text.Text = "";
                phone_text.Text = "";
                Adders_text.Text = "";
                ID_text.Text = "";
                GrideEmployee();


            }
        }

        private void Delete_Emp_Click(object sender, EventArgs e)
        {
            if (First_name_text.Text == "" || Ls_text.Text == "" || ID_text.Text == "" || Salary_text.Text == "" || phone_text.Text == ""
            || Adders_text.Text == "")
            {
                MessageBox.Show("Plase Select Data");
            }
            else
            {
                dbcontent = new Car_Company_DB();
                Emp = new Employee();
                Emp.ID = int.Parse(ID_text.Text);
                Emp.FirstName = First_name_text.Text;
                Emp.LastName = First_name_text.Text;
                Emp.Salary = double.Parse(Salary_text.Text);
                Emp.Phone = int.Parse(phone_text.Text);
                Emp.Adderss = Adders_text.Text;

                dbcontent.Entry(Emp).State = System.Data.Entity.EntityState.Deleted;
                dbcontent.SaveChanges();
                First_name_text.Text = "";
                Ls_text.Text = "";
                Salary_text.Text = "";
                phone_text.Text = "";
                Adders_text.Text = "";
                ID_text.Text = "";
                GrideEmployee();
            }
        }

        private void Cleartext_box_Click(object sender, EventArgs e)
        {
            First_name_text.Text = "";
            Ls_text.Text = "";
            Salary_text.Text = "";
            phone_text.Text = "";
            Adders_text.Text = "";
            ID_text.Text = "";
        }
    }
}