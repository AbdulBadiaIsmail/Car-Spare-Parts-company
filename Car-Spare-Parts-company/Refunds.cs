namespace Car_Spare_Parts_company
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Refunds
    {
        public int id { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public string Productname { get; set; }

        [Column("data of refund")]
        public DateTime data_of_refund { get; set; }

        public int ProductPrice { get; set; }

        public int amount { get; set; }
    }
}
