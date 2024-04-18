using DotNetCP2.Data;
using DotNetCP2.DTOs;
using DotNetCP2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCP2.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;

        public RegisterController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult RegisterDTO(RegisterDTO request)
        {
            var users = _dataContext.t_Users.FirstOrDefault(linha => linha.UserEmail == request.UserEmail);
            if (users != null)
            {
                return BadRequest("Usuário já existente!");
            }
            User NewUser = new User
            {
                UserEmail = request.UserEmail,
                UserName = request.UserName,
                UserPassword = request.UserPassword,
            };
            _dataContext.t_Users.Add(NewUser);
            _dataContext.SaveChanges();
            return Ok("Usuário Cadastrado!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

