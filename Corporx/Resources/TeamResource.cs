using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corporx.Resources
{
    public class TeamResource
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string WorkPosition { get; set; }
        public string Comment { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Dribbble { get; set; }
        public string[] Photos { get; set; }
    }
}
