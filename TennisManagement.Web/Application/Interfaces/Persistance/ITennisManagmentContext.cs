namespace TennisManagement.Web.Application.Interfaces.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using TennisManagement.Web.Models.Matches;
    using TennisManagement.Web.Models.Roster;

    public interface ITennisManagementContext
    {
        DbSet<Match> Matches { get; }
        DbSet<Player> Players { get; }

        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default);
    }
}
