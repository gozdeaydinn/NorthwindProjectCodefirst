using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("CustomerDemographics")]
    public class CustomerDemographic
    {
        [Key]
        [Column(Order = 1)]
        public string TypeID { get; set; }
        public string CustomerDesc { get; set; }
        public List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
