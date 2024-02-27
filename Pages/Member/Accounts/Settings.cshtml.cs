using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrillionaireWepApp.Pages.Member.Accounts
{
    public class SettingsModel : PageModel
    {
		private readonly ILogger<SettingsModel> _logger;
		public SettingsModel(ILogger<SettingsModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
        {
        }
    }
}
