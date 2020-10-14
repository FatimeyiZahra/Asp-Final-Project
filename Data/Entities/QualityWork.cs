using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class QualityWork : BaseEntity
    {
        public string Name { get; set; }
        //public int CategoryId { get; set; }

        //public Category Category { get; set; }

        public List<QualityWorkCategory> QualityWorkCategories { get; set; }

        public ICollection<QualityPhoto> QualityPhotos { get; set; }


    }
}
