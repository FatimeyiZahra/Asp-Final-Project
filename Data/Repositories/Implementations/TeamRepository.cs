using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        private ApplicationDbContext _context => Context as ApplicationDbContext;

        public TeamRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Team>> GetPhotoForPhotoId(object photoId)
        {
            return await _context.Teams
                .Include(p => p.TeamPhotos).ToListAsync();
        }

        public async Task<IEnumerable<Team>> GetTeamsWithPhotoAsync()
        {
            return await _context.Teams
                 .Include(p => p.TeamPhotos).ToListAsync();
        }

        //public async Task<IEnumerable<Team>> Get

    }
}
