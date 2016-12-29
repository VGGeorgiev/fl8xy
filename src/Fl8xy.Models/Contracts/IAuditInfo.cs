namespace Fl8xy.Data.Contracts
{
    using System;

    public interface IAuditInfo : IEntity
    {
        DateTime CreatedOn { get; set; }

        DateTime ModifiedOn { get; set; }
    }
}
