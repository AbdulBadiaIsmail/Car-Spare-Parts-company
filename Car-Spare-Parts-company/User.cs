using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Spare_Parts_company
{
   public class User
    {
        public int id { get; set; }

        [Column(TypeName ="nvarchar(max)")]
        public string username { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(20)][MinLength(6)]
        

        public string Password { get; set; }
          [MaxLength(20)]
        public string type { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int MobileNO { get; set; }


        [ForeignKey("employees")]
        public int? employeeid { get; set; }
        public virtual Employee employees { get; set; }

        [ForeignKey("HRS")]
        public int? HRSid { get; set; }
        public virtual HR HRS { get; set; }

    }
}
