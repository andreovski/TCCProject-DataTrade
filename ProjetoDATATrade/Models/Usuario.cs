using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDATATrade.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [Display(Name = "Nome Completo"), StringLength(200, MinimumLength = 10)]
        public string NomeCompleto { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual Trader Trader { get; set; }
        public virtual Carteira Carteira { get; set; }
        public virtual Login Login { get; set; }

        public ICollection<Operacao> Operacoes { get; set; }


    }
}
