using ProjetoDATATrade.Data;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories
{
    public class TraderRep : ITraderRep
    {
        private readonly IESContext _dbContext;

        public TraderRep(IESContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AlterarDadosTrader(Trader trader)
        {
            _dbContext.Update(trader);
            _dbContext.SaveChanges();
        }
        public void InserirDadosTrader(Trader trader)
        {
            _dbContext.Add(trader);
            _dbContext.SaveChanges();
        }
    }
}
