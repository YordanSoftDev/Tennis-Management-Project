namespace TennisManagement.Web.Infrastructure.Configurations.Matches
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisManagement.Web.Models.Matches;

    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.DateTime)
                .IsRequired(true);

            builder.Property(m => m.CourtName)
                .IsRequired(true)
                .HasMaxLength(100);

            builder.Property(m => m.CourtType)
                .IsRequired(true)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(m => m.MatchFormat)
                .IsRequired(true)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(m => m.MatchKind)
                .IsRequired(true)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(m => m.ScoreResult)
                .HasMaxLength(100);

            builder.Property(m => m.DurationMinutes);

            builder.Property(m => m.MatchStatus)
                .IsRequired(true)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.HasOne(m => m.Venue)
                .WithMany()
                .HasForeignKey(m => m.VenueId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Tournament)
                .WithMany()
                .HasForeignKey(m => m.TournamentId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.FirstPlayer)
                .WithMany()
                .HasForeignKey(m => m.FirstPlayerId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.SecondPlayer)
                .WithMany()
                .HasForeignKey(m => m.SecondPlayerId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Winner)
                .WithMany()
                .HasForeignKey(m => m.WinnerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
