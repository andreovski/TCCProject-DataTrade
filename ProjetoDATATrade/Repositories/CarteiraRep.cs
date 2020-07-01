using ProjetoDATATrade.Data;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories
{
    public class CarteiraRep : ICarteiraRep
    {
        private readonly IESContext _dbContext;
        public CarteiraRep(IESContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AlterarDados(Carteira carteira)
        {
            _dbContext.Update(carteira);
            _dbContext.SaveChanges();
        }

        public Carteira CalcularSaldo(Carteira carteira, Operacao operacao)
        {
            float novoSaldo;
            if (operacao.Resultado >= 0) //Se a radiobox estiver setada como ganho = true //Pegando o Lucro e o saldo final apartir do Risco e resultado das operações
            {               
                novoSaldo = carteira.Saldo - operacao.Risco;
                carteira.Lucro = operacao.Resultado - operacao.Risco;
                carteira.Saldo = novoSaldo + operacao.Resultado;

                return carteira;
            }
            else
            {
                novoSaldo = carteira.Saldo - operacao.Risco;
                carteira.Lucro = operacao.Resultado - operacao.Risco;
                carteira.Saldo = novoSaldo - operacao.Resultado;

                return carteira;
            }

        }
        public void InserirDados(Carteira carteira)
        {
            _dbContext.Add(carteira);
            _dbContext.SaveChanges();
        }
    }
}
