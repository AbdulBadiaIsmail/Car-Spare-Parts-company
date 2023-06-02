using System;
using System.Data.Entity;
using System.Linq;

namespace Car_Spare_Parts_company
{
    public class Car_Company_DB : DbContext
    {
 
        public Car_Company_DB()
            : base("name=Model1")
        {
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Bill> bills { get; set; }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Client> Clients { get; set; }  
        public DbSet<HR> HRs { get; set; }
        public virtual DbSet<Refunds> Refunds { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }
}