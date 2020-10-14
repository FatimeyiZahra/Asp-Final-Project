using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data.Repositories.Interfaces
{
    public interface ITeamRepository : IRepository<Team>
    {
        Task<IEnumerable<Team>> GetPhotoForPhotoId(object photoId);
        Task<IEnumerable<Team>> GetTeamsWithPhotoAsync();
    }
}
