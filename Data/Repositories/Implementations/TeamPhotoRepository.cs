using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class TeamPhotoRepository : Repository<TeamPhoto>, ITeamPhotoRepository

    {
        public TeamPhotoRepository(ApplicationDbContext context) : base(context) { }
    }
}
