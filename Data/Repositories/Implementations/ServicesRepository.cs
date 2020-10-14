using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class ServicesRepository : Repository<Services>, IServicesRepository
    {
        public ServicesRepository(ApplicationDbContext context) : base(context) { }
    }
}
