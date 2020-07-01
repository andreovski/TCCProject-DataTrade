using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface ITraderRep
    {
        void InserirDadosTrader(Trader trader);
        void AlterarDadosTrader(Trader trader);
    }
}
