namespace Fl8xy.Models
{
    using Base;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Project : IdentifiableDeletableEntity<int>
    {
        public string Name { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [InverseProperty("Project")]
        public List<UserProjects> Participants { get; set; }

        public List<Sprint> Sprints { get; set; }

        public List<State> States { get; set; }
    }
}
