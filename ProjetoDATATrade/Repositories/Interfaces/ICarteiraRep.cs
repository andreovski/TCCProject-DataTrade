using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface ICarteiraRep
    {
        void InserirDados(Carteira carteira);
        void AlterarDados(Carteira carteira);
        Carteira CalcularSaldo(Carteira carteira, Operacao operacao);
    }
}
