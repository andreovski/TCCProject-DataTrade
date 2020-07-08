using ProjetoDATATrade.Data;
using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public class IndicadorRep : IIndicadorRep
    {
        private readonly IESContext _dbContext;
        public IndicadorRep(IESContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AlterarIndicador(Indicador indicador)
        {
            _dbContext.Update(indicador);
            _dbContext.SaveChanges();
        }

        public void CadastrarIndicador(Indicador indicador)
        {
            _dbContext.Add(indicador);
            _dbContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            Indicador indicador = ObterIndicador(id);
            _dbContext.Remove(indicador);
            _dbContext.SaveChanges();
        }

        public Indicador ObterIndicador(int id)
        {
            return _dbContext.Indicadores.Find(id);              
        }

        public IEnumerable<Indicador> ObterTodosIndicador()
        {
            return _dbContext.Indicadores.ToList();
        }
    }
}
