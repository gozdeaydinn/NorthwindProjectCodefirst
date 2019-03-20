using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Entity
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        [Required]
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitInStock { get; set; }
        public short? UnitOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool? Discontinued { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
