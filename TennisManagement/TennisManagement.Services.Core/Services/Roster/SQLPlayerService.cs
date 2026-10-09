namespace TennisManagement.Services.Core.Services.Roster
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TennisManagement.ViewModels.Roster;
    using TennisManagement.Data.Models.Roster;
    using TennisManagement.Data.Persistance;
    using TennisManagement.Services.Core.Contracts.Roster;

    public class SQLPlayerService : IPlayerService
    {
        private readonly TennisManagementDbContext context;
        private readonly IMapper mapper;

        public SQLPlayerService(TennisManagementDbContext context,
        IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> CreatePlayerAsync(PlayerFormViewModel playerForm)
        {
            Player newPlayer = this.mapper.Map<Player>(playerForm);

            this.context.Players.Add(newPlayer);
            await this.context.SaveChangesAsync();

            return newPlayer.Id;
        }

        public async Task<bool> UpdatePlayerAsync(int id, PlayerFormViewModel playerForm)
        {
            Player? playerToUpdate = await this.context.Players.FindAsync(id);

            if (playerToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(playerForm, playerToUpdate);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePlayerAsync(int id)
        {
            int rowsAffected = await this.context.Players
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<PlayerDetailsViewModel?> GetPlayerDetailsByIdAsync(int id)
        {
            return await this.context.Players
                .Where(m => m.Id == id)
                .ProjectTo<PlayerDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<PlayerFormViewModel?> GetPlayerForEditByIdAsync(int id)
        {
            return await this.context.Players
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<PlayerFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllPlayersForIndexAsync()
        {
            return await this.context.Players
                .AsNoTracking()
                .OrderBy(p => p.Id)
                .ProjectTo<PlayerInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
