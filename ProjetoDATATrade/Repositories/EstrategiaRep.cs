using ProjetoDATATrade.Data;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories
{
    public class EstrategiaRep : IEstrategiaRep
    {
        private readonly IESContext _dbContext;

        public EstrategiaRep(IESContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AlterarEstrategia(Estrategia estrategia)
        {
            _dbContext.Update(estrategia);
            _dbContext.SaveChanges();
        }

        public Estrategia LocalizarEstrategia(Estrategia estrategia)
        {
            if (estrategia.EstrategiaID == 0)
            {
                estrategia = _dbContext.Estrategias.Where(e => e.Nome == estrategia.Nome).First();
                return estrategia;
            }
            else
            {
                estrategia = _dbContext.Estrategias.Where(e => e.EstrategiaID == estrategia.EstrategiaID).First();
                return estrategia;
            }
        }
        public void CadastrarEstrategia(Estrategia estrategia)
        {
            _dbContext.Add(estrategia);
            _dbContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            Estrategia estrategia = ObterEstrategia(id);
            _dbContext.Remove(estrategia);
            _dbContext.SaveChanges();
        }

        public Estrategia ObterEstrategia(int id)
        {
            return _dbContext.Estrategias.Find(id);
        }

        public IEnumerable<Estrategia> ObterTodasEstrategia()
        {
           return _dbContext.Estrategias.ToList();
        }
    }
}
