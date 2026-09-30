namespace TennisManagement.Web.Application.Services.Matches
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TennisManagement.Web.Application.Interfaces.Matches;
    using TennisManagement.Web.Application.Interfaces.Persistance;
    using TennisManagement.Web.Models.Matches;
    using TennisManagement.Web.ViewModels.Matches;
    using TennisManagement.Web.ViewModels.Roster;

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

        public async Task<int> CreateMatchAsync(MatchFormViewModel matchForm)
        {
            Match newMatch = this.mapper.Map<Match>(matchForm);

            this.context.Matches.Add(newMatch);
            await this.context.SaveChangesAsync();

            return newMatch.Id;
        }

        public async Task<bool> UpdateMatchAsync(int id, MatchFormViewModel matchForm)
        {
            Match? matchToUpdate = await this.context.Matches.FindAsync(id);

            if(matchToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(matchForm, matchToUpdate);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteMatchAsync(int id)
        {
            int rowsAffected = await this.context.Matches
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id)
        {
            return await this.context.Matches
                .Where(m => m.Id == id)
                .ProjectTo<MatchDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<MatchFormViewModel?> GetMatchForEditByIdAsync(int id)
        {
            return await this.context.Matches
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync()
        {
              return await this.context.Matches
                 .AsNoTracking()
                 .OrderBy(m => m.DateTime)
                 .ThenBy(m => m.Id)
                 .ProjectTo<MatchInfoViewModel>(this.mapper.ConfigurationProvider)
                 .ToListAsync();
        }

        public async Task<IEnumerable<PlayerSelectViewModel>> GetPlayersForSelectAsync()
        {
            return await this.context.Players
                .AsNoTracking()
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName)
                .ProjectTo<PlayerSelectViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
