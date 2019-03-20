using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("EmplooyeTerritories")]
    public class EmplooyeTerritory
    {
        [Key]
        [Column(Order = 1)]
        public int EmplooyeID { get; set; }
        public virtual Employee Employee { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TerritoryID { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
