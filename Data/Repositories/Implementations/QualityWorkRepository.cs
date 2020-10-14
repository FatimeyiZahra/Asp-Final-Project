using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class QualityWorkRepository : Repository<QualityWork>, IQualityWorkRepository
    {
        public QualityWorkRepository(ApplicationDbContext context) : base(context) { }
    }
}
