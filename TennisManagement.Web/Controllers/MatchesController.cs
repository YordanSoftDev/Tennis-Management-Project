namespace TennisManagement.Web.Controllers
{    
    using Microsoft.AspNetCore.Mvc;
    using TennisManagement.Web.Application.Interfaces;
    using TennisManagement.Web.ViewModels.Matches;

    public class MatchesController : Controller
    {
        private readonly IMatchService service;

        public MatchesController(IMatchService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<MatchInfoViewModel> matches = await this.service.GetAllMatchesForIndexAsync();

            return this.View(matches);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            MatchDetailsViewModel? matchDetails = await this.service.
                GetMatchDetailsByIdAsync(id);

            if(matchDetails == null)
            {
                return this.NotFound();
            }

            return this.View(matchDetails);
        }

        [HttpGet]
        public IActionResult Create()
        {
            MatchFormViewModel matchForm = new MatchFormViewModel();

            return this.View(matchForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MatchFormViewModel matchForm)
        {
            if(!this.ModelState.IsValid)
            {
                return this.View(matchForm);
            }

            int createdMatchId = await this.service.CreateMatchAsync(matchForm);

            return this.RedirectToAction(nameof(Details), 
                new { id = createdMatchId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            MatchFormViewModel? matchForm = await this.service
                .GetMatchForEditByIdAsync(id);

            if(matchForm == null)
            {
                return this.NotFound();
            }

            return this.View(matchForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]      
        public async Task<IActionResult> Edit(int id, MatchFormViewModel matchForm)
        {
            if(!this.ModelState.IsValid)
            {
                return this.View(matchForm);
            }

            bool isUpdated = await this.service.UpdateMatchAsync(id, matchForm);

            if(!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details), new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            MatchDetailsViewModel? matchDetails = await this.service
                .GetMatchDetailsByIdAsync(id);

            if(matchDetails == null)
            {
                return this.NotFound();
            }

            return this.View(matchDetails);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isDeleted = await this.service.DeleteMatchAsync(id);

            if(!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }
    }
}
