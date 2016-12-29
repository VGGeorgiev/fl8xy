namespace Fl8xy.Models
{
    using Fl8xy.Models.Base;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Story : IdentifiableAuditInfo<int>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int StateId { get; set; }

        public State State { get; set; }

        public int ParentStoryId { get; set; }

        public Story ParentStory { get; set; }

        [InverseProperty("ParentStory")]
        public List<Story> Tasks { get; set; }

        public int Points { get; set; }
    }
}