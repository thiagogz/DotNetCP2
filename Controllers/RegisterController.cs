using Microsoft.AspNetCore.Mvc;

namespace DotNetCP2.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
