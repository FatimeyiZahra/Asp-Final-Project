using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
  public  class QualityWorkCategory
    {
        public int Id { get; set; }
        public int QualityWorkId { get; set; }
        public int CategoryId { get; set; }
        public QualityWork QualityWork { get; set; }
        public Category Category { get; set; }
    }
}
