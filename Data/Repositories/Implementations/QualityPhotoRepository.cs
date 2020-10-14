using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class QualityPhotoRepository : Repository<QualityPhoto>, IQualityPhotoRepository
    {
        public QualityPhotoRepository(ApplicationDbContext context) : base(context) { }
    }
}
