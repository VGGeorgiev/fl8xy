namespace Fl8xy.Models
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ApplicationUser : IdentityUser
    {
        [InverseProperty("ApplicationUser")]
        public List<Project> CreatedProjects { get; set; }

        [InverseProperty("User")]
        public List<UserProjects> ParticipatedProjects { get; set; }
    }
}
