using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class TeamPhoto :BaseEntity
    {
        public int TeamId { get; set; }
        public string Photo { get; set; }

        public Team Team { get; set; }
    }
}
