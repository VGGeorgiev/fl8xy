namespace Fl8xy.Models
{
    using Data.Contracts;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ApplicationUser : IdentityUser, IEntity
    {
        [InverseProperty("ApplicationUser")]
        public List<Project> CreatedProjects { get; set; }

        [InverseProperty("User")]
        public List<UserProjects> ParticipatedProjects { get; set; }
    }
}
