using Microsoft.AspNetCore.Mvc;

namespace DialPortal.Controllers
{
    public class CallHistoryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
