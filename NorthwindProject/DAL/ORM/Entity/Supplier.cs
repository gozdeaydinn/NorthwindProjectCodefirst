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
    [Table("Suppliers")]
    public class Supplier : BaseEntity, IAdressInfo
    {
        [Required]
        public int CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }

        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public List<Product> Products { get; set; }



    }
}
