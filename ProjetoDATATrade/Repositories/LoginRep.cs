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
        public Login Login(string Email, string Senha)
        {
            Login login = _dbContext.Logins.Where(l => l.Email == Email && l.Senha == Senha).First();
            return login;
        }
    }
}
