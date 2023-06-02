using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Car_Spare_Parts_company
{
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        Car_Company_DB mdd2 = new Car_Company_DB();
        DateTime dt; decimal ee;
        Refunds reff;
        XtraForm1 fm;
        List<object> lio = new List<object>();
        public XtraForm2(XtraForm1 fm)
        {
            this.fm = fm;
            InitializeComponent();
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {
            dt = DateTime.UtcNow;

            comboBoxEdit1.Properties.Items.AddRange(mdd2.Clients.Select(r => r.Name).ToArray());
            comboBoxEdit2.Properties.Items.AddRange(mdd2.products.Select(r => r.Name).ToArray());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedItem != null && comboBoxEdit2.SelectedItem != null && spinEdit1.Value > 0)
            {
                var prodNam = comboBoxEdit2.SelectedItem.ToString();


                 ee = mdd2.products.FirstOrDefault(r => r.Name == prodNam).SellingPrice;


               lio.Add(  new{  ClientName=comboBoxEdit1.SelectedItem.ToString(),ProductName= comboBoxEdit2.SelectedItem.ToString(),
                    Quantity=spinEdit1.Value.ToString(),Datetime= dt.ToString() ,price=Convert.ToInt32(ee)}
                  );
               
                gridControl2.DataSource= lio.ToList();



                ;
            }
            else
            {
                XtraMessageBox.Show("fill all data","Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lio.Count>0)
            {
                foreach (dynamic item in lio)
                {

                    reff = new Refunds()
                    {
                        ClientName = item.ClientName,
                        Productname = item.ProductName,
                        amount = Convert.ToInt32(item.Quantity),
                        data_of_refund = Convert.ToDateTime(item.Datetime),
                        ProductPrice = item.price
                    };
                    var prodName = reff.Productname;
                    var prodamount = mdd2.products.Where(r => r.Name == prodName).SingleOrDefault().Amount;
                    mdd2.products.Where(r => r.Name == prodName).SingleOrDefault().Amount += reff.amount ;

                    mdd2.Refunds.Add(reff);
                }
                mdd2.SaveChanges();
                Hide();
                fm = new XtraForm1();

                fm.ShowDialog();
                Close();
            }
            else
            {
                XtraMessageBox.Show("there is no items to add ", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;
            lio.Clear();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
                 if (XtraMessageBox.Show($"are you sure you want to delete ", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          
                      {
                         lio.Remove(gridView1.GetFocusedRow());

                         gridView1.DeleteSelectedRows();

                    }
                



        }
    }
}