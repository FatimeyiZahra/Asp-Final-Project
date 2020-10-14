using Data.Repositories.Implementations;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private CategoryRepository _categoryRepository;
        private ClientRepository _clientRepository;
        private ClientPhotoRepository _clientPhotoRepository;
        private CorporxRepository _corporxRepository;
        private NewsRepository _newsRepository;
        private QualityPhotoRepository _qualityPhotoRepository;
        private QualityWorkRepository _qualityWorkRepository;
        private ServicesRepository _servicesRepository;
        private TeamPhotoRepository _teamPhotoRepository;
        private TeamRepository _teamRepository;
        private QualityWorkCategoryRepository _qualityWorkCategoryRepository;



        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }
        public ICategoryRepository Category => _categoryRepository ??= new CategoryRepository(_context);
        public IClientPhotoRepository ClientPhotoRepository => _clientPhotoRepository ??= new ClientPhotoRepository(_context);
        public IClientRepository ClientRepository => _clientRepository ??= new ClientRepository(_context);
        public ICorporxRepository CorporxRepository => _corporxRepository ??= new CorporxRepository(_context);
        public INewsRepository NewsRepository => _newsRepository ??= new NewsRepository(_context);
        public IQualityPhotoRepository QualityPhotoRepository => _qualityPhotoRepository ??= new QualityPhotoRepository(_context);
        public IQualityWorkRepository QualityWorkRepository => _qualityWorkRepository ??= new QualityWorkRepository(_context);
        public IServicesRepository ServicesRepository => _servicesRepository ??= new ServicesRepository(_context);
        public ITeamRepository teamRepository => _teamRepository ??= new TeamRepository(_context);
        public ITeamPhotoRepository teamPhotoRepository => _teamPhotoRepository ??= new TeamPhotoRepository(_context);

        public IClientPhotoRepository ClientPhoto => _clientPhotoRepository ??= new ClientPhotoRepository(_context);

        public IClientRepository Client => _clientRepository ??= new ClientRepository(_context);

        public ICorporxRepository Corporx => _corporxRepository ??= new CorporxRepository(_context);

        public INewsRepository News => _newsRepository ??= new NewsRepository(_context);

        public IQualityPhotoRepository QualityPhoto => _qualityPhotoRepository ??= new QualityPhotoRepository(_context);

        public IQualityWorkRepository QualityWork => _qualityWorkRepository ??= new QualityWorkRepository(_context);

        public IServicesRepository Service => _servicesRepository ??= new ServicesRepository(_context);

        public ITeamRepository Team => _teamRepository ??= new TeamRepository(_context);
        public IQualityWorkCategoryRepository QualityWorkCategory => _qualityWorkCategoryRepository ??= new QualityWorkCategoryRepository(_context);


        public ITeamPhotoRepository TeamPhoto => _teamPhotoRepository ??= new TeamPhotoRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
