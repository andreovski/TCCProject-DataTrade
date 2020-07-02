using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Models
{
    public class Indicador
    {
        [Key]
        public int InidicadorID { get; set; }
        [Required]
        public string Titulo { get; set; }
        public virtual Trader Trader { get; set; }

    }
}
