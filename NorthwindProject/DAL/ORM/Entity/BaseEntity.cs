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
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }


        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }

        private DateTime _updateDate = DateTime.Now;
        public DateTime UpdateDate { get { return _updateDate; } set { _updateDate = value; } }

        private DateTime _delectedDate = DateTime.Now;
        public DateTime DelectedDate { get { return _delectedDate; } set { _delectedDate = value; } }

        private Status _status = Status.Active;
        public Status status { get { return _status; } set { _status = value; } }
        private Role _role;
        public Role role { get { return _role; } set { _role = value; } }
    }
}
