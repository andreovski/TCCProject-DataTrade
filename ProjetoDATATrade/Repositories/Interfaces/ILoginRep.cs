using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface ILoginRep
    {
        void CadastrarLogin(Login login);
        public bool AlterarSenha(int id, string Senha, string NovaSenha);
        bool ValidarEmail(string Email);
        Login Login(string Email, string Senha);
    }
}
