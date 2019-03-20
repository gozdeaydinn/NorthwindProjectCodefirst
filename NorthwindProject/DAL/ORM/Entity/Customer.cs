using NorthwindProject.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("Customers")]
    public class Customer : BaseEntity, IAdressInfo
    {
        [Required]
        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        [MaxLength(255)]
        public string ContactTitle { get; set; }

        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }

        public List<Order> Orders { get; set; }
        public List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
