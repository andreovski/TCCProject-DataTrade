using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoDATATrade.Libs.LoginLibs;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;

namespace ProjetoDATATrade.Controllers
{
    public class AuthController : Controller
    {
        private ILoginRep _loginRep;
        private LoginUsuario _loginUsuario;
        public AuthController(ILoginRep loginRep, LoginUsuario loginUsuario)
        {
            _loginRep = loginRep;
            _loginUsuario = loginUsuario;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm] Login login)
        {
            Login loginDB = _loginRep.Login(login.EmailLogin, login.Senha);
            if (loginDB != null)
            {
                _loginUsuario.LoginSessao(loginDB);
                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                ViewData["MSG_E"] = "Usuario não encontrado";
                return View();
            }
        }
        public ContentResult Painel()
        {
             return Content("Logado com sucesso!");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verificacao(Login login)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
