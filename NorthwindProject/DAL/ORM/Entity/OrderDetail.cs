using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("OrderDetails")]
    public class OrderDetail : BaseEntity
    {

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }//miktar
        public float Discount { get; set; }//indirim



    }
}
