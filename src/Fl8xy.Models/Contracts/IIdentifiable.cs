namespace Fl8xy.Data.Contracts
{
    public interface IIdentifiable<TKey>
    {
        TKey Id { get; set; }
    }
}
