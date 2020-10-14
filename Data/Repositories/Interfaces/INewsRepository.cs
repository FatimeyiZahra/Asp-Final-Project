using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data.Repositories.Interfaces
{
    public interface INewsRepository : IRepository<News>
    {
        Task<IEnumerable<News>> GetAllNewWithCategories();
    }
}
