using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class CorporxRepository : Repository<Corporx>, ICorporxRepository
    {
        public CorporxRepository(ApplicationDbContext context) : base(context) { }
    }
}
