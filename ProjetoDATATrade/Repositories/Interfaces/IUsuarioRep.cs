using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface IUsuarioRep
    {
        void Cadastrar(Login usuario);
        void AlterarCadastro(Login usuario);
        void ExcluirCadastro(int id);
        void ValidarEmail(Login usuario);
    }
}
