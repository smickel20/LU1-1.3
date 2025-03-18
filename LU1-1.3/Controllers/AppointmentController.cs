using Microsoft.AspNetCore.Mvc;

namespace LU1_1._3.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
