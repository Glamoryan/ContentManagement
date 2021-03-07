using Microsoft.AspNetCore.Mvc;

namespace CapsNet.ContentManagementSystem.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
