using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDATATrade.Libs.LoginLibs;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories;
using ProjetoDATATrade.Repositories.Interfaces;
using ProjetoDATATrade.Controllers;

namespace ProjetoDATATrade.Controllers
{
    public class AuthenticationController : Controller
    {
        public class ViewModelRegistro
        {
            //USUARIO MODELS
            public string NomeCompleto { get; set; }
            public string Email { get; set; }
            //LOGIN MODELS
            public string Senha { get; set; }
        }
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
            var Existe = _loginRep.ValidarEmail(login.Email);
            if (Existe)
            {
                Login log = new Login();
                Login loginDB = _loginRep.Login(login.Email, login.Senha);
                if (loginDB != null)
                {
                    log.LoginID = loginDB.LoginID;
                    log.UsuarioID = loginDB.UsuarioID;
                    log.Email = login.Email;
                    log.Senha = login.Senha;
                    if (log != null)
                    {
                        _loginUsuario.LoginSessao(log);
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        TempData["sErrMsg"] = "Falha ao cadastrar sessão";
                        return View();
                    }
                }
                else
                {
                    TempData["sErrMsg"] = "Senha incorreta";
                    return RedirectToAction("Login", "Authentication");
                }
            }
            else
            {
                TempData["sErrMsg"] = "Email não cadastrado";
                return new RedirectResult(Url.Action(nameof(Register)));
            }
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
        public IActionResult Register([FromForm] ViewModelRegistro vMRegistro)
        {
            if (ModelState.IsValid)
            {
                var naoexiste = _usuarioRep.VerificarEmail(vMRegistro.Email);
                if (naoexiste)
                {
                    Usuario usuario = new Usuario();
                    Login login = new Login();
                    usuario.Email = vMRegistro.Email;
                    usuario.NomeCompleto = vMRegistro.NomeCompleto;
                    _usuarioRep.Cadastrar(usuario);
                    login.UsuarioID = usuario.UsuarioID;
                    login.Email = usuario.Email;
                    login.Senha = vMRegistro.Senha;
                    _loginRep.CadastrarLogin(login);
                    //MENSAGEM LOGADO COM SUCESSO
                    return RedirectToAction("Login", "Authentication");
                }
                else
                {
                    //MENSAGEM DE EMAIL JA CADASTRADO
                    return View();
                }

            }
            return View();
        }
    }
}