using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("Regions")]
    public class Region : BaseEntity
    {
        [MaxLength(255)]
        public string RegionDescription { get; set; }
        public List<Territory> Territories { get; set; }
    }
}
