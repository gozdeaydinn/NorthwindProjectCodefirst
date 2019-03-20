using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("Shippers")]
    public class Shipper : BaseEntity
    {
        [Required]
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }

    }
}
