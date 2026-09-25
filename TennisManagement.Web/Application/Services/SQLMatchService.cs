namespace TennisManagement.Web.Application.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TennisManagement.Web.Application.Interfaces;
    using TennisManagement.Web.Application.Interfaces.Persistance;
    using TennisManagement.Web.Models.Matches;
    using TennisManagement.Web.ViewModels.Matches;

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
            IEnumerable<Match> matches = await this.context
                .Matches
                .Include(m => m.Venue)
                .Include(m => m.Tournament)
                .Include(m => m.FirstPlayer)
                .Include(m => m.SecondPlayer)
                .Include(m => m.Winner)
                .OrderBy(m => m.DateTime)
                .ThenBy(m => m.Id)
                .ToListAsync();

            return this.mapper.Map<IEnumerable<MatchInfoViewModel>>(matches);
        }
    }
}
