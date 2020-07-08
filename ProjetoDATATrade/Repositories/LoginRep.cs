using ProjetoDATATrade.Data;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories
{
    public class LoginRep : ILoginRep
    {
        private readonly IESContext _dbContext;

        public LoginRep(IESContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AlterarSenha(int id, string Senha, string NovaSenha)
        {
            Login loginDB = _dbContext.Logins.Where(l => l.LoginID == id && l.Senha == Senha).FirstOrDefault();
            if(loginDB != null)
            {
                loginDB.Senha = NovaSenha;
                _dbContext.Update(loginDB);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void CadastrarLogin(Login login)
        {
            _dbContext.Add(login);
            _dbContext.SaveChanges();
        }
        public Login Login(string Email, string Senha)
        {
            Login login = _dbContext.Logins.Where(l => l.Email == Email && l.Senha == Senha).FirstOrDefault();
            return login;
        }
        public bool ValidarEmail(string Email)
        {
            var usuario = _dbContext.Usuarios.Where(u => u.Email == Email).FirstOrDefault();
            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
