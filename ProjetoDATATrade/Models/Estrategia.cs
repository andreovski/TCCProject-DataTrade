using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDATATrade.Models
{
    public class Estrategia
    {
        [Key]
        public int EstrategiaID { get; set; }
        [ForeignKey("UsuarioID")]
        public int UsuarioID { get; set; }

        [Required]
        [Display(Name = "Nome da Estrategia")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Onde?")]
        public string Onde { get; set; } 
        [Required]
        [Display(Name = "Como?")]
        public string Como { get; set; }
        [Required]
        [Display(Name = "Porque?")]
        public string Porque { get; set; }
        [Required]
        [Display(Name = "Quando?")]
        public string Quando { get; set; }

        public virtual Usuario Usuario { get; set; }
        public ICollection<Operacao> Operacoes { get; set; }

    }
}
