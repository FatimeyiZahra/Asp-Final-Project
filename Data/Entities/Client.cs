using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Client : BaseEntity
    {
        public string FullName { get; set; }
        public string WorkPosition { get; set; }
        public string Comment { get; set; }
        public ICollection<ClientPhoto> ClientPhotos { get; set; }
    }
}
