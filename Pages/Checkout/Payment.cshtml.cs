using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrillionaireWepApp.Pages.Checkout
{
    public class PaymentModel : PageModel
    {
        private readonly ILogger<PaymentModel> _logger;

        public PaymentModel(ILogger<PaymentModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
