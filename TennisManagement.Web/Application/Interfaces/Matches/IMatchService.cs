using Microsoft.AspNetCore.Mvc;
using TennisManagement.Web.ViewModels.Matches;
using TennisManagement.Web.ViewModels.Roster;

namespace TennisManagement.Web.Application.Interfaces.Matches
{
    public interface IMatchService
    {
        public Task<int> CreateMatchAsync(MatchFormViewModel matchForm);

        public Task<bool> UpdateMatchAsync(int id, MatchFormViewModel matchForm);

        public Task<bool> DeleteMatchAsync(int id);

        public Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id);

        public Task<MatchFormViewModel?> GetMatchForEditByIdAsync(int id);

        public Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync();

        public Task<IEnumerable<PlayerSelectViewModel>> GetPlayersForSelectAsync();
    }
}

