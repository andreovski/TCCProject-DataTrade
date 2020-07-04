using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using NPOI.SS.Formula.Functions;

namespace ProjetoDATATrade.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        [ForeignKey("UsuarioID")]
        public int? UsuarioID { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
