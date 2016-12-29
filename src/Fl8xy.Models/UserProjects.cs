using Fl8xy.Data.Contracts;

namespace Fl8xy.Models
{
    public class UserProjects : IEntity
    {
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
