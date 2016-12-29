namespace Fl8xy.Models
{
    using Fl8xy.Models.Base;

    public class State : IdentifiableAuditInfo<int>
    {
        public string Name { get; set; }
    }
}