using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Spare_Parts_company
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Bill> Bills { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
