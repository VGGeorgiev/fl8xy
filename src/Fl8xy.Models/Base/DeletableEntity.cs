using Fl8xy.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fl8xy.Models.Base
{
    public abstract class DeletableEntity : AuditInfo, IDeletableEntity
    {
        public DateTime DeletedOn { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}
