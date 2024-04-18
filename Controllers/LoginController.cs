using Microsoft.AspNetCore.Mvc;

namespace DotNetCP2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
