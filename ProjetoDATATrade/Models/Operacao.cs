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
        [Key]
        [ForeignKey("UsuarioID")]
        public int OperacaoID { get; set; }

        [Required]
        public string Ativo{ get; set; }

        [Required]
        public string Estrategia{ get; set; }

        [Required]
        [Display(Name = "Data e Hora")]
        public string DataeHora{ get; set; }

        public float Carteira { get; set; }

        public float Risco { get; set; }

        [Display(Name = "Preço da Entrada")]
        public float PrecoEntrada { get; set; }

        public float TakeProfit { get; set; }

        public float StopLoss { get; set; }

        public float Resultado { get; set; }

        [Required]
        public string Ordem { get; set; }

        public float Lote { get; set; }

        [Display(Name = "Numero da Operacao")]
        public int NumeroOperacao { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}
