using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrillionaireWepApp.Pages.Member
{
    public class SignUpModel : PageModel
    {
		private readonly ILogger<SignUpModel> _logger;

		public SignUpModel(ILogger<SignUpModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
        {
        }
    }
}
