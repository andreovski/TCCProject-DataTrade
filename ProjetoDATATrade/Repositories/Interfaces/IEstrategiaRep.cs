using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface IEstrategiaRep
    {
        void CadastrarEstrategia(Estrategia estrategia);
        public Estrategia LocalizarEstrategia(Estrategia estrategia);
        void AlterarEstrategia(Estrategia estrategia);
        void Excluir(int id);
        Estrategia ObterEstrategia(int id);
        IEnumerable<Estrategia>ObterTodasEstrategia();
    }
}
