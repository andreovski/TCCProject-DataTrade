using Newtonsoft.Json;
using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Libs.LoginLibs
{
    public class LoginUsuario
    {
        // Injetando a sessao no construtor
        private string key = "Login.Usuario";
        private Sessao.Sessao _sessao;
        public LoginUsuario(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        //Cadastrar Sessao quando o usuario for efetuar o login
        public void LoginSessao(Login login)
        {
            string loginJSONstr = JsonConvert.SerializeObject(login);
            _sessao.Cadastrar(key, loginJSONstr);
        }
        //recuperando o usuario apos serializa-lo para validar a sessao
        public Login GetLogin()
        {
            if (_sessao.Existe(key))
            {
                string loginJSONstr = _sessao.Consultar(key);
                return JsonConvert.DeserializeObject<Login>(loginJSONstr);
            }
            else
            {
                return null;
            }
        }
        public void LogoutSessao()
        {

        }
    }
}
