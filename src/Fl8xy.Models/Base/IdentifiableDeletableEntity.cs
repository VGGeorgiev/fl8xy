namespace Fl8xy.Models.Base
{
    using Fl8xy.Data.Contracts;

    public abstract class IdentifiableDeletableEntity<TKey> : DeletableEntity, IIdentifiable<TKey>
    {
        public TKey Id { get; set; }
    }
}
