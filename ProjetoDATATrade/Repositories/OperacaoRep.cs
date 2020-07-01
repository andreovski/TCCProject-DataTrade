using ProjetoDATATrade.Data;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories
{
    public class OperacaoRep : IOperacaoRep
    {
        private readonly IESContext _dbContext;

        public OperacaoRep(IESContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AlterarOperacoes(Operacao operacao)
        {
            _dbContext.Update(operacao);
            _dbContext.SaveChanges();
        }

        public void ExcluirOperacoes(int id)
        {
            Operacao operacoes = ObterOperacoes(id);
            _dbContext.Remove(operacoes);
            _dbContext.SaveChanges();
        }
        public Operacao ObterOperacoes(int id)
        {
            return _dbContext.Operacoes.Find(id);
        }
        public IEnumerable<Operacao> ObterTodasOperacoes()
        {
            return _dbContext.Operacoes.ToList();
        }
        public void GerarRelatorio(Operacao operacao)
        {
            
        }
        public void InserirOperacoes(Operacao operacao)
        {
            _dbContext.Add(operacao);
            _dbContext.SaveChanges();
        }
    }
}
