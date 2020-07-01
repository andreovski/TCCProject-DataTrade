﻿using ProjetoDATATrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories.Interfaces
{
    public interface IUsuarioRep
    {
        void Cadastrar(Usuario usuario);
        void AlterarCadastro(Usuario usuario);
        void ExcluirCadastro(int id);
        void ValidarEmail(Usuario usuario);
    }
}
