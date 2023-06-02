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
using System.Data.Entity;

namespace Car_Spare_Parts_company
{
    public partial class SUPPLIERS : DevExpress.XtraEditors.XtraForm
    {

        Supplier model = new Supplier();
        Car_Spare_Parts_company.Car_Company_DB dbContext;
        public SUPPLIERS()
        {
            InitializeComponent();
            dbContext = new Car_Spare_Parts_company.Car_Company_DB();
            dbContext.suppliers.Load();
            DisplyGrideView();
        }
        void DisplyGrideView()
        {
            // gridControl1.DataSource = dbContext.suppliers.Local.ToBindingList();
            dbContext = new Car_Spare_Parts_company.Car_Company_DB();

            gridControl1.DataSource = dbContext.suppliers.Select(ww => new { ww.ID, ww.Name }).ToList();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            dbContext =new  Car_Spare_Parts_company.Car_Company_DB();
            int id = int.Parse(text_id.Text);
            var supid = dbContext.suppliers.Where(x => x.ID == id).FirstOrDefault();

            if(text_Name.Text == " "  || text_id.Text == "")
            {
                MessageBox.Show("pleas inter Name");
            }
            else if (supid !=null )
            {
                MessageBox.Show("can not add Suppliers");
            }
            else
            {
                model.ID = int.Parse(text_id.Text);
                model.Name = text_Name.Text;
                dbContext.suppliers.Add(model);
                dbContext.SaveChanges();
                DisplyGrideView();
                text_Name.Text = "";
                text_id.Text = "";
            }
         
        }

        private void changeSuppliers(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            text_id.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            text_Name.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dbContext = new Car_Spare_Parts_company.Car_Company_DB();
            if (text_id.Text !="" && text_Name.Text!="")
            {
               
                model.ID = int.Parse(text_id.Text);
                model.Name = text_Name.Text;
                dbContext.Entry(model).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
                DisplyGrideView();
                text_Name.Text = "";
                text_id.Text = "";
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {



        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dbContext = new Car_Spare_Parts_company.Car_Company_DB();

            if (text_id.Text!= "" || text_Name.Text!="" )
            {
           
               model.ID = int.Parse(text_id.Text);
                model.Name = text_Name.Text;
                dbContext.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                dbContext.SaveChanges();
                DisplyGrideView();
                text_Name.Text = "";
                text_id.Text = "";
            }
        }

        private void SUPPLIERS_Load(object sender, EventArgs e)
        {
            text_Name.Text = "";
            text_id.Text = "";
        }
    }
}