﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ProjetoDATATrade.Models
{
    public class Trader
    {
    

        [ForeignKey("EstrategiaID")]
        public int UsuarioID { get; set; }

        [Key]
        public int TraderID { get; set; }

        [Required]
        [Display(Name = "Perfil do Trader")]
        public string PerfilTrader { get; set; }

        [Required]
        [Display(Name = "Dias de Operação")]
        public string DiasOperacao { get; set; }

        [Required]
        [Display(Name = "Horário de Operação")]
        public string HorarioOperacao { get; set; }

        [Display(Name = "Objetivo de Ganho Diário")]
        public float ObjetivoGanhoDiario { get; set; }

        [Display(Name = "Objetivo de Ganho Semanal")]
        public float ObjetivoGanhoSemanal { get; set; }

        [Display(Name = "Objetivo de Ganho Mensal")]
        public float ObjetivoGanhoMensal { get; set; }

        [Display(Name = "Limite de Perda Diária")]
        public float LimitePerdaDiaria { get; set; }

        [Display(Name = "Limite de Perda Semanal")]
        public float LimitePerdaSemanal { get; set; }

        [Display(Name = "Limite de Perda Mensal")]
        public float LimitePerdaMensal { get; set; }

        [Required]
        [Display(Name = "Ativo Operado")]
        public string AtivoOperado { get; set; }

        [Required]
        public string Indicadores { get; set; }

        [Required]
        [Display(Name = "Principais Candles")]
        public string PrincipaisCandle { get; set; }

        public virtual Usuario Usuario { get; set; }


      //  public virtual Estrategia Estrategia { get; set; }
    }
}
