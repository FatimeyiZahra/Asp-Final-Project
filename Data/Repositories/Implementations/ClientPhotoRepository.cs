using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class ClientPhotoRepository : Repository<ClientPhoto>, IClientPhotoRepository
    {
        public ClientPhotoRepository(ApplicationDbContext context) : base(context) { }
    }
}
