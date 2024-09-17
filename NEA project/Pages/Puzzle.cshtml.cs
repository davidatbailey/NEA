using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NEA_project.Pages
{
    public class PuzzleModel : PageModel
    {
        private readonly ILogger<PuzzleModel> _logger;

        public PuzzleModel(ILogger<PuzzleModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}