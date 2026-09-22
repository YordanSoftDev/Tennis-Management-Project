using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace TennisManagement.Web.Application.Interfaces.Persistance
{
    public interface ITennisManagementContext
    {
        DbSet<Match> Matches { get; }

        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default);
    }
}
