using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrillionaireWepApp.Pages.Checkout
{
    public class CheckoutModel : PageModel
    {
		private readonly ILogger<CheckoutModel> _logger;

		public CheckoutModel(ILogger<CheckoutModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
        {
        }
    }
}
