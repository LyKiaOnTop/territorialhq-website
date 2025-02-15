using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TerritorialHQ.Services;
using TerritorialHQ_Library.DTO;

namespace TerritorialHQ.Areas.Administration.Pages.Journal
{
    [Authorize(Roles = "Administrator, Journalist")]
    public class DetailsModel : PageModel
    {
        private readonly JournalArticleService _journalArticleService;

        public DetailsModel(JournalArticleService journalArticleService)
        {
            _journalArticleService = journalArticleService;
        }

        public DTOJournalArticle? Article { get; set; }

        public async Task<IActionResult> OnGet(string id)
        {
            Article = await _journalArticleService.FindAsync<DTOJournalArticle>("JournalArticle", id);
            if (Article == null)
                return NotFound();

            return Page();
        }
    }
}
