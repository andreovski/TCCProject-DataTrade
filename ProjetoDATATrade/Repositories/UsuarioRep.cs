using ProjetoDATATrade.Data;
using ProjetoDATATrade.Models;
using ProjetoDATATrade.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Repositories
{
    public class UsuarioRep : IUsuarioRep
    {
        private readonly IESContext _dbContext;

        public UsuarioRep(IESContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AlterarCadastro(Usuario usuario)
        {
            _dbContext.Update(usuario);
            _dbContext.SaveChanges();
        }

        public void Cadastrar(Usuario usuario)
        {
            _dbContext.Add(usuario);
            _dbContext.SaveChanges();
        }

        public void ExcluirCadastro(int id)
        {
            Usuario usuario = ObterUsuarios(id);
            _dbContext.Remove(usuario);
            _dbContext.SaveChanges();
        }
        public Usuario ObterUsuarios(int id)
        {
            return _dbContext.Usuarios.Find(id);
        }

        public bool ValidarEmail(string Email)
        {
            var usuario = _dbContext.Usuarios.Single(u => u.Email == Email);/*.FirstOrDefault();*/
            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
