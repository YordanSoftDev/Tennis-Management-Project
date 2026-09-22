using TennisManagement.Web.ViewModels.Matches;

namespace TennisManagement.Web.Application.Interfaces
{
    public interface IMatchService
    {
        public Task<int> CreateMatchAsync(MatchFormViewModel model);

        public Task<bool> UpdateMatchAsync(int id, MatchFormViewModel model);

        public Task<bool> DeleteMatchAsync(int id);

        public Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id);

        public Task<MatchFormViewModel?> GetMatchForEditByAsync(int id);

        public Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync();
    }
}

