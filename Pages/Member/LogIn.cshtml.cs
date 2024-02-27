using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrillionaireWepApp.Pages.Member
{
    public class LogInModel : PageModel
    {
        private readonly ILogger<LogInModel> _logger;

        public LogInModel(ILogger<LogInModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
