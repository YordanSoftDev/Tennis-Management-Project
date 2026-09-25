namespace TennisManagement.Web.Application.Interfaces.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using TennisManagement.Web.Models.Matches;
    public interface ITennisManagementContext
    {
        DbSet<Match> Matches { get; }
        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default);
    }
}
