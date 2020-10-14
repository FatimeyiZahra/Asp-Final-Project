using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Category :BaseEntity
    {
        public string Name { get; set; }
        //public ICollection<QualityWork> QualityWorks { get; set; }
        //public ICollection<NewsCategory> NewsCategories { get; set; }
        public List<NewsCategory> NewsCategories { get; set; }
        public List<QualityWorkCategory> QualityWorkCategories { get; set; }



    }
}
