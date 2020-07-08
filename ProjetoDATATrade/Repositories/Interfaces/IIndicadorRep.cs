using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface IIndicadorRep 
    {
        void CadastrarIndicador(Indicador indicador);
        void AlterarIndicador(Indicador indicador);
        void Excluir(int id);
        Indicador ObterIndicador(int id);
        IEnumerable<Indicador> ObterTodosIndicador();
    }
}
