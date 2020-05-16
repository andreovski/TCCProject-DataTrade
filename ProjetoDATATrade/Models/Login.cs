using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDATATrade.Models
{
    public class Login
    {
        [Key]
        [ForeignKey("UsuarioID")]
        public int LoginID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
