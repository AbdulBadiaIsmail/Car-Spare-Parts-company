using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Spare_Parts_company
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public int Phone { get; set; }
        public string Adderss { get; set; }
        //Employee Client Relation 

        public List<Client> clients { get; set; }
        //Employee Products Relation 

        public List<Product> products { get; set; }


        //Employee Supplier Relation 
        public List<Supplier> suppliers { get; set; }

        //Employee Hr Relation
        public HR Hrs { get; set; }


    }
}
