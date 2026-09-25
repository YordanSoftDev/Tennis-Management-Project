using Microsoft.EntityFrameworkCore;
using TennisManagement.Web.Application.Interfaces.Persistance;
using TennisManagement.Web.Models.Matches;

namespace TennisManagement.Web.Infrastructure.Persistance
{
    public partial class TennisManagementContext : DbContext, ITennisManagementContext
    {
        public TennisManagementContext(DbContextOptions<TennisManagementContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Match> Matches { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TennisManagementContext).Assembly);

            this.OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
