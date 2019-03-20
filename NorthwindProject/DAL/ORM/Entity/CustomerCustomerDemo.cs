using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("CustomerCustomerDemos")]
    public class CustomerCustomerDemo
    {
        [Key]
        [Column(Order = 1)]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        [Key]
        [Column(Order = 2)]
        public string CustomerTypeID { get; set; }
        public virtual CustomerDemographic CustomerDemographic { get; set; }
    }
}
