namespace Fl8xy.Models.Base
{
    using Fl8xy.Data.Contracts;
    using System.ComponentModel.DataAnnotations;

    public abstract class IdentifiableAuditInfo<TKey> : AuditInfo, IIdentifiable<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
