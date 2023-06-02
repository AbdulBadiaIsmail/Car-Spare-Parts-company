using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Spare_Parts_company
{
    public class HR
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public int Phone { get; set; }
        public string Adderss { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
