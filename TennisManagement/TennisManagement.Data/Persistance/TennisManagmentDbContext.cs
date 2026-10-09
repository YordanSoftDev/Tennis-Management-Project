namespace TennisManagement.Data.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using TennisManagement.Data.Models.Matches;
    using TennisManagement.Data.Models.Roster;

    public partial class TennisManagementDbContext : DbContext
    {
        public TennisManagementDbContext(DbContextOptions<TennisManagementDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Match> Matches { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TennisManagementDbContext).Assembly);

            this.OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
