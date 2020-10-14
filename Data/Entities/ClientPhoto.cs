using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class ClientPhoto : BaseEntity
    {
        public int ClientId { get; set; }
        public string Photo { get; set; }
        public Client Client { get; set; }
    }
}
