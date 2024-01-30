using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrillionaireWepApp.Pages
{
    public class BasketModel : PageModel
    {
		private readonly ILogger<BasketModel> _logger;

		public BasketModel(ILogger<BasketModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
        {
        }
    }
}
