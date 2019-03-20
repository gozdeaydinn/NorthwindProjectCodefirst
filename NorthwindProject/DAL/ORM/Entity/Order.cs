using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("Orders")]
    public class Order : BaseEntity
    {
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int EmplooyeID { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("ShipVia")]
        public virtual Shipper Shipper { get; set; }


    }
}
