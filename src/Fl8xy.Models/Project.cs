namespace Fl8xy.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [InverseProperty("Project")]
        public List<UserProjects> Participants { get; set; }
    }
}
