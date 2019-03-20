using NorthwindProject.DAL.ORM.Enum;
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
    [Table("Employees")]
    public class Employee : BaseEntity, IAdressInfo
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string Title { get; set; }
        public string TitleOfCourtney { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte?[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public List<Order> Orders { get; set; }
        public List<EmplooyeTerritory> EmplooyeTerritories { get; set; }



        //[NotMapped]
        //public List<Employee> Employees { get; set; }
    }
}
