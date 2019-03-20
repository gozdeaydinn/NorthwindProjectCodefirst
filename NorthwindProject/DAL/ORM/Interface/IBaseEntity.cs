using NorthwindProject.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DAL.ORM.Interface
{
    public interface IBaseEntity
    {
        DateTime AddDate { get; set; }
        DateTime UpdateDate { get; set; }
        DateTime DelectedDate { get; set; }
        
    }
}
