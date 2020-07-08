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
using ProjetoDATATrade.Controllers;


namespace ProjetoDATATrade.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOperacaoRep _operacaoRep;
        private readonly IUsuarioRep _usuarioRep;
        private readonly LoginUsuario _loginUsuario;
        private readonly IEstrategiaRep _estrategiaRep;

        public HomeController(IOperacaoRep operacaoRep, IUsuarioRep usuarioRep, LoginUsuario loginUsuario,IEstrategiaRep estrategiaRep)
        {
            _operacaoRep = operacaoRep;
            _usuarioRep = usuarioRep;
            _loginUsuario = loginUsuario;
            _estrategiaRep = estrategiaRep;

        }
        public class ViewModelRegistro : Operacao 
        {
            //ESTRATEGIA
            public string Nome { get; set; }
            public string Onde { get; set; }
            public string Como { get; set; }
            public string Porque { get; set; }
            public string Quando { get; set; }
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Estrategia()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Operacao()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Rentabilidade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Estrategia([FromForm]ViewModelRegistro vMRestrategia)
        {
            Estrategia estrategia = new Estrategia();
            estrategia.Nome = vMRestrategia.Nome;
            estrategia.Quando = vMRestrategia.Quando;
            estrategia.Como = vMRestrategia.Como;
            estrategia.Onde = vMRestrategia.Onde;
            estrategia.Porque = vMRestrategia.Porque;
            _estrategiaRep.CadastrarEstrategia(estrategia);
            //MENSAGEM ESTRATEGIA INSERIDA COM SUCESSO
            return RedirectToAction("DTrade", "Home");
        }
        [HttpPost]
        public IActionResult Operacao([FromForm]ViewModelRegistro vMRoperacao)
        {
            Estrategia estrategia = new Estrategia();
            estrategia.Nome = vMRoperacao.EstrategiaOperacao;
            estrategia = _estrategiaRep.LocalizarEstrategia(estrategia);
            vMRoperacao.EstrategiaID = estrategia.EstrategiaID;

            Operacao operacao = new Operacao();
            Login login = new Login();
            _loginUsuario.GetLogin(login);
            List<Operacao> dadosOperacao = new List<Operacao>();
            dadosOperacao.Add(vMRoperacao);
            foreach (Operacao d in dadosOperacao)
            {
                operacao = d;
            }

            operacao.UsuarioID = login.UsuarioID;
            _operacaoRep.InserirOperacoes(operacao);
            //MENSAGEM OPERAÇÃO INSERIDA COM SUCESSO
            return RedirectToAction("DTrade", "Home");
        }
        public IActionResult DTrade()
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
