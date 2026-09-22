using TennisManagement.Web.Application.Interfaces;
using TennisManagement.Web.Application.Interfaces.Persistance;
using TennisManagement.Web.ViewModels.Matches;

namespace TennisManagement.Web.Application.Services
{
    using AutoMapper;

    public class SQLMatchService : IMatchService
    {
        private readonly ITennisManagementContext context;
        private readonly IMapper mapper; 

        public SQLMatchService(ITennisManagementContext context,
        IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> CreateMatchAsync(MatchFormViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateMatchAsync(int ID, MatchFormViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteMatchAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<MatchFormViewModel?> GetMatchForEditByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync()
        {
            throw new NotImplementedException();
        }
    }
}
