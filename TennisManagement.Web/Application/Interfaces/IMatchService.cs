using TennisManagement.Web.ViewModels.Matches;

namespace TennisManagement.Web.Application.Interfaces
{
    public interface IMatchService
    {
        public Task<int> CreateMatchAsync(MatchFormViewModel matchForm);

        public Task<bool> UpdateMatchAsync(int id, MatchFormViewModel matchForm);

        public Task<bool> DeleteMatchAsync(int id);

        public Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id);

        public Task<MatchFormViewModel?> GetMatchForEditByIdAsync(int id);

        public Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync();
    }
}

