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
        
        [ForeignKey("UsuarioID")]
        public int UsuarioID { get; set; }
        [Key]
        public int LoginID { get; set; }
        [Required]
        public string EmailLogin { get; set; }
        [Required]
        public string Senha { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
