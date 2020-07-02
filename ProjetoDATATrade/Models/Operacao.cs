using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDATATrade.Models
{
    public class Operacao
    {
     
        [ForeignKey("UsuarioID")]
        public int UsuarioID { get; set; }
        [ForeignKey("EstrategiaID")]
        public int EstrategiaID { get; set; }
        [Key]
        public int OperacaoID { get; set; }

        [Required]
        public string Ativo{ get; set; }

        [Required]
        public string EstrategiaOperacao{ get; set; }

        [Required]
        [Display(Name = "Data e Hora")]
        public string DataeHora{ get; set; }
        [Required]
        public float Carteira { get; set; }
        [Required]
        public float Risco { get; set; }

        [Display(Name = "Preço da Entrada")]
        public float PrecoEntrada { get; set; }
        [Required]
        public float TakeProfit { get; set; }
        [Required]
        public float StopLoss { get; set; }
        [Required]
        public float Resultado { get; set; }

        [Required]
        public string Ordem { get; set; }
        [Required]
        public float Lote { get; set; }

        [Display(Name = "Numero da Operacao")]
        public int NumeroOperacao { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Estrategia Estrategia { get; set; }

    }
}
