using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{

    [Table("Categories")]
    public class Category : BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }

        [MaxLength(255)]
        public string CategoryDescription { get; set; }
        public byte?[] Picture { get; set; }

        public List<Product> Products { get; set; }

    }
}
