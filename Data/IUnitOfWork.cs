using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IClientPhotoRepository ClientPhoto { get; }
        IClientRepository Client { get; }
        ICorporxRepository Corporx { get; }
        INewsRepository News { get; }
        IQualityPhotoRepository QualityPhoto { get; }
        IQualityWorkRepository QualityWork { get; }
        IServicesRepository Service { get; }
        ITeamRepository Team { get; }
        ITeamPhotoRepository TeamPhoto { get; }
        IQualityWorkCategoryRepository QualityWorkCategory { get; }
        Task<int> CommitAsync();
    }
}
