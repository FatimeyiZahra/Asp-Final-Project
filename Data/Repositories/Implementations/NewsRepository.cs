using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        private ApplicationDbContext _context => Context as ApplicationDbContext;
        public NewsRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<News>> GetNewsByNewsId()
        {
            return await _context.News
                   .Include("NewsCategories")
                   .Include("NewsCategories.Category")
                   .Where(n => n.Status)
                   .ToListAsync();
        }

        public async Task<IEnumerable<News>> GetAllNewWithCategories()
        {
            return await _context.News
                  .Include("NewsCategories")
                  .Include("NewsCategories.Category")
                  .Where(n => n.Status)
                  .ToListAsync();
        }
    }
    
}
