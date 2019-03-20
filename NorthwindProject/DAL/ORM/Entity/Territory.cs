using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("Territories")]
    public class Territory : BaseEntity
    {
        [MaxLength(255)]
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public virtual Region Region { get; set; }
        public List<EmplooyeTerritory> EmplooyeTerritories { get; set; }

    }
}
