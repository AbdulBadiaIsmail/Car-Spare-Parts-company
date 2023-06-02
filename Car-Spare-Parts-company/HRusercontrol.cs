﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Car_Spare_Parts_company
{
    public partial class HRusercontrol : UserControl
    {
        private int id;
        private Car_Company_DB cd;
        public HRusercontrol()
        {
            InitializeComponent();
          

            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.AutoSize = false;
        }

        private void HRusercontrol_Load(object sender, EventArgs e)
        {
        
             
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            cd = new Car_Spare_Parts_company.Car_Company_DB();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            cd.employees.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                employeesBindingSource.DataSource = cd.employees.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                gridView1.SetRowCellValue(gridView1.GetRowHandle(4), "DOE", "kk");
            }
            textEdit1.Text=(gridView1.GetFocusedRow() as dynamic).FirstName;
            textEdit2.Text = (gridView1.GetFocusedRow() as dynamic).LastName;
            textEdit3.Text = ((gridView1.GetFocusedRow() as dynamic).Salary).ToString();
            id= (gridView1.GetFocusedRow() as dynamic).ID;

        }

        private void simpleButtonMinus2_Click(object sender, EventArgs e)
        {

            if (textEdit4.Text.Length>0)
            {
                var empSAl=cd.employees.Find(id).Salary;
                cd.employees.Find(id).Salary = empSAl - ((empSAl * int.Parse(textEdit4.Text)/100  ) );
                cd.SaveChanges();
            }
            else
            {
                MessageBox.Show("enter value");
            }
            
            HRusercontrol_Load(null, null);

        }

        private void simpleButtonADD3_Click(object sender, EventArgs e)
        {
            if (textEdit4.Text.Length > 0)
            {
                var empSAl = cd.employees.Find(id).Salary;
                cd.employees.Find(id).Salary = ((empSAl * int.Parse(textEdit4.Text) / 100) + empSAl);
                cd.SaveChanges();
            }
            else
            {
                MessageBox.Show("enter value");
            }

            HRusercontrol_Load(null, null);
        }
    }
}
