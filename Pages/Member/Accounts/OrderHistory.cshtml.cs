using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrillionaireWepApp.Pages.Member.Accounts
{
    public class OrderHistoryModel : PageModel
    {
		private readonly ILogger<OrderHistoryModel> _logger;
		public OrderHistoryModel(ILogger<OrderHistoryModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
