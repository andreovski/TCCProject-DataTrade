using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDATATrade.Libs.LoginLibs;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories;
using ProjetoDATATrade.Repositories.Interfaces;

namespace ProjetoDATATrade.Controllers
{
    public class AuthenticationController : Controller
    {
        private ILoginRep _loginRep;
        private LoginUsuario _loginUsuario;
        private IUsuarioRep _usuarioRep;
        public AuthenticationController(ILoginRep loginRep, LoginUsuario loginUsuario, IUsuarioRep usuarioRep)
        {
            _loginRep = loginRep;
            _loginUsuario = loginUsuario;
            _usuarioRep = usuarioRep;

        }
        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Login login) 
        {
            //var Existe = _usuarioRep.ValidarEmail(login.Email);
            //if (Existe)
            //{
                Login loginDB = _loginRep.Login(login.Email, login.Senha);
                if (loginDB != null)
                {
                    _loginUsuario.LoginSessao(loginDB);
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                //ModelState.AddModelError("Senha.Invalida","Senha Inválida! caso tenha esquecido, clique em recuperar");
                    TempData["sErrMsg"] = "Email e senha não conferem";

                    return View();
                //return RedirectToAction("Login", "Authentication");
                }
            //}
            //else
            //{
            //    ModelState.AddModelError("email.inexistente", "Esse email não está cadastrado em nosso sistemas");
            //    return new RedirectResult(Url.Action(nameof(Register)));
            //}
        }

        public PartialViewResult ShowErrorLogin(String sErrorMessage)
        {
            return PartialView("ErrorMessageViewLogin");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register([FromForm] Usuario usuario)
        {
            return View();
        }
    }
}