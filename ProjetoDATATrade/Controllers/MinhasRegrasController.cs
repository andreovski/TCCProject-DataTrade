using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDATATrade.Libs.LoginLibs;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;
using ProjetoDATATrade.Controllers;


namespace ProjetoDATATrade.Controllers
{
    public class MinhasRegrasController : Controller
    {
        private readonly IIndicadorRep _indicadorRep;
        private readonly ICarteiraRep _carteiraRep;
        private readonly ITraderRep _traderRep;
        private readonly LoginUsuario _loginUsuario;
        private readonly ILoginRep _loginRep;
        public MinhasRegrasController(ILoginRep loginRep, LoginUsuario loginUsuario, ITraderRep traderRep, IIndicadorRep indicadorRep, ICarteiraRep carteiraRep)
        {
            _loginRep = loginRep;
            _loginUsuario = loginUsuario;
            _indicadorRep = indicadorRep;
            _carteiraRep = carteiraRep;
            _traderRep = traderRep;
        }
        public class ViewModelRegistro : Trader
        {
            //ALTERAR LOGIN
            public string Senha { get; set; }
            public string SenhaNova { get; set; }
            //PERFILTRADER
            public string Nome { get; set; }
            //Indicador
            public string NomeIndicador { get; set; }
            //CARTEIRA 
            public float Saldo { get; set; }
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Carteira()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Indicador()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Trader()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DTrade()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RecuperarAlterarSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecuperarAlterarSenha([FromForm]ViewModelRegistro vMRegistro)
        {
            Login login = new Login();
            login = _loginUsuario.GetLogin(login);
            login.Senha = vMRegistro.Senha;
            if(vMRegistro.SenhaNova != login.Senha)
            {
                var alterado = _loginRep.AlterarSenha(login.LoginID, login.Senha, vMRegistro.SenhaNova);
                if (alterado)
                {
                    //MENSAGEM DE SENHA ALTERADA COM SUCESSO
                    return RedirectToAction("Index", "MinhasRegras");
                }
                //MENSAGEM DE ERRO NA MUDANÇA DE SENHA
                return RedirectToAction("Index", "MinhasRegras");
            }
            else
            {
                //MENSAGEM A SENHA QUE VOCE ESTA TENTANDO MUDAR É IGUAL A ANTERIOR
                return RedirectToAction("Index", "MinhasRegras");
            }
        }
        [HttpPost]
        public IActionResult Carteira(Carteira carteira)
        {
            Login login = new Login();
            login = _loginUsuario.GetLogin(login);
            carteira.UsuarioID = login.UsuarioID;
            _carteiraRep.InserirDados(carteira);
            //MENSAGEM DADOS INSERIDOS COM SUCESSO
            return View();
        }
        [HttpPost]
        public IActionResult Indicador([FromForm]Indicador indicador)
        {
            _indicadorRep.CadastrarIndicador(indicador);
            //MENSAGEM INDICADOR INSERIDO COM SUCESSO
            return View();
        }
        [HttpPost]
        public IActionResult Trader([FromForm]Trader trader, PerfilTrader perfil)
        {
            Login login = new Login();
            login = _loginUsuario.GetLogin(login);
            trader.UsuarioID = login.UsuarioID;
            List<Trader> traders = new List<Trader>();
            traders.Add(trader);
            foreach (Trader t in traders)
            {
                trader = t;
            }
            if(perfil.Nome.Equals(trader.PerfilTrader))
            {
                trader.PerfilTraderID = perfil.PerfilTraderID;
            }
            _traderRep.InserirDadosTrader(trader);
            //MENSAGEM TRADER INSERIDO
            return View();
        }
    }
}