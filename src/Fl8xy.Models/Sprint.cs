using Fl8xy.Models.Base;
using System;
using System.Collections.Generic;

namespace Fl8xy.Models
{
    public class Sprint : IdentifiableDeletableEntity<int>
    {
        public int Number { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Goal { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public List<Story> Stories { get; set; }
    }
}
