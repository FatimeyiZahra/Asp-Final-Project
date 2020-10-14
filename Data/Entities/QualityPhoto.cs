using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class QualityPhoto :BaseEntity
    {
        public int QualityWorkId { get; set; }
        public string Photo { get; set; }
        public QualityWork QualityWork { get; set; }
    }
}
