using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoDATATrade.Models
{
    public class Carteira
    {
      
        [ForeignKey("UsuarioID")]
        public int UsuarioID { get; set; }
        [Key]
        public int CarteiraID { get; set; }
        public float Saldo { get; set; }
        [Display(Name = "Total Acumalado")]
        public float TotalAcumulado { get; set; }
        public float Lucro { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
