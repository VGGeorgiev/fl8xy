namespace Fl8xy.Models.Base
{
    using System;
    using Fl8xy.Data.Contracts;

    public abstract class AuditInfo : IAuditInfo
    {
        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}
