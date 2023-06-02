using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Spare_Parts_company
{
    public class Product
    {
        [Column("ID")]
        public int ID { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }

        //Product bill relation 

        public List<Bill> bills { get; set; }

    }
}
