namespace TennisManagement.Web.Controllers.Matches
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using TennisManagement.Web.Application.Interfaces.Matches;
    using TennisManagement.Web.ViewModels.Matches;
    using TennisManagement.Web.Models.Matches.MatchEnumerations;


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
            IEnumerable<MatchInfoViewModel> matches = await 
                this.service.GetAllMatchesForIndexAsync();

            return this.View(matches);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            MatchDetailsViewModel? matchDetails = await 
                this.service.GetMatchDetailsByIdAsync(id);

            if(matchDetails == null)
            {
                return this.NotFound();
            }

            return this.View(matchDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var players = await this
                .service.GetPlayersForSelectAsync();
            var model = new MatchFormViewModel
            {
                Players = players
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FullName
                })
            };

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MatchFormViewModel matchForm)
        {
            bool isCompleted = matchForm.MatchStatus == MatchStatus.Completed;

            if(isCompleted && !matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner must be selected when " +
                    "the match status is Completed.");
            }

            if (!isCompleted && matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner can only be assigned " +
                    "if the match status is Completed.");
            }


            if (!this.ModelState.IsValid)
            {
                return this.View(matchForm);
            }

            int createdMatchId = await this.service
                .CreateMatchAsync(matchForm);

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
            bool isCompleted = matchForm.MatchStatus == MatchStatus.Completed;

            if (isCompleted && !matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner must be selected when the match status is Completed.");
            }

            if (!isCompleted && matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner can only be assigned if the match status is Completed.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(matchForm);
            }

            bool isUpdated = await this.service.UpdateMatchAsync(id, matchForm);

            if(!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details), 
                new { id = id });
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
