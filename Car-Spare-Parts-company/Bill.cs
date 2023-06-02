using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Spare_Parts_company
{
    public class Bill
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int BillAmount { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }

        //Product Bill Relation 
        public List<Product> products { get; set; }

        public Supplier Supplier { get; set; }

        public Client Client { get; set; }  

    }
}
