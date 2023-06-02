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
    public partial class SalaryMangment : DevExpress.XtraEditors.XtraForm
    {

        Car_Company_DB database;
        Employee emp;
        public SalaryMangment()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            textBox1.Text = gridView1.GetFocusedRowCellValue("Salary").ToString();

            ID_textBox.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }

        private void DisplayAlldata()
        {
            database =new Car_Company_DB();
            gridControl1.DataSource = database.employees.Select(x => new { x.ID, x.FirstName, x.LastName, x.Salary, x.Phone, x.Adderss }).ToList();
        }

        private void SalaryMangment_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            DisplayAlldata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                database = new Car_Company_DB();
                emp = new Employee();
                double bouns;
                emp.ID = int.Parse(ID_textBox.Text);
                emp.Salary = double.Parse(textBox1.Text);
                bouns = double.Parse(textBox2.Text);
                emp.Salary = bouns * emp.Salary;
                database.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                database.SaveChanges();
                DisplayAlldata();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception m)
            {
                MessageBox.Show( m.Message);
            }
         
        }
    }
}