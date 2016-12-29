using System;

namespace Fl8xy.Data.Contracts
{
    public interface IDeletableEntity : IEntity
    {
        bool IsDeleted { get; set; }

        DateTime DeletedOn { get; set; }
    }
}
