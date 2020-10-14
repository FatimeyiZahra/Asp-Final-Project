using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    class QualityWorkCategoryRepository : Repository<QualityWorkCategory>, IQualityWorkCategoryRepository
    {
        public QualityWorkCategoryRepository(ApplicationDbContext context) : base(context) { }

    }
}
