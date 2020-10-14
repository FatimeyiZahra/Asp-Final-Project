using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Team :BaseEntity
    {
        public string FullName { get; set; }
        public string WorkPosition { get; set; }
        public string Comment { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Dribbble { get; set; }

        public ICollection<TeamPhoto> TeamPhotos { get; set; }
    }
}
