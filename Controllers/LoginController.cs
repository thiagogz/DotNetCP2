using DotNetCP2.Data;
using DotNetCP2.DTOs;
using DotNetCP2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCP2.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;

        public LoginController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginDTO(LoginDTO request)
        {
            var find = _dataContext.t_Users.FirstOrDefault(x => x.UserEmail == request.UserEmail);
            if (find == null)
            {
                return NotFound();
            }
            if (find.UserPassword != request.UserPassword)
            {
                return BadRequest("Senha inválida!");
            }
            ViewBag.userData = find;
            return View(find);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

