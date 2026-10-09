namespace TennisManagement.Web.Controllers.Roster
{
    using Microsoft.AspNetCore.Mvc;
    using TennisManagement.ViewModels.Roster;
    using TennisManagement.Services.Core.Contracts.Roster;

    public class PlayersController : Controller
    {
        private readonly IPlayerService service;

        public PlayersController(IPlayerService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<PlayerInfoViewModel> players = await
                this.service.GetAllPlayersForIndexAsync();

            return this.View(players);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            PlayerDetailsViewModel? playerDetails = await
                this.service.GetPlayerDetailsByIdAsync(id);

            if (playerDetails == null)
            {
                return this.NotFound();
            }

            return this.View(playerDetails);
        }

        [HttpGet]
        public IActionResult Create()
        {
            PlayerFormViewModel playerForm = new PlayerFormViewModel();

            return this.View(playerForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlayerFormViewModel playerForm)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(playerForm);
            }

            int createdPlayerId = await this.service
                .CreatePlayerAsync(playerForm);

            return this.RedirectToAction(nameof(Details),
                new { id = createdPlayerId });
        }

        [HttpGet]
        public async Task<IActionResult?> Edit(int id)
        {
            PlayerFormViewModel? playerForm = await
                this.service.GetPlayerForEditByIdAsync(id);

            if (playerForm == null)
            {
                return this.NotFound();
            }

            return this.View(playerForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PlayerFormViewModel playerForm)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(playerForm);
            }

            bool isUpdated = await this.service
                .UpdatePlayerAsync(id, playerForm);

            if (!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details),
                new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            PlayerDetailsViewModel? playerDetails = await this.service
                .GetPlayerDetailsByIdAsync(id);

            if (playerDetails == null)
            {
                return this.NotFound();
            }

            return this.View(playerDetails);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isDeleted = await this.service.DeletePlayerAsync(id);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }


    }
}
