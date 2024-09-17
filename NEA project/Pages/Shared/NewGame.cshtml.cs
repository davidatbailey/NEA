using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NEA_project.Pages
{
    public class NewGameModel : PageModel
    {
        private readonly ILogger<NewGameModel> _logger;

        public NewGameModel(ILogger<NewGameModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}