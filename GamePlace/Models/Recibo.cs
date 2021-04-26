using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GamePlace.Models
{
    public class Recibo{

        /// <summary>
        /// PK para a tabela do relacionamento entre Jogo e Utilizadores
        /// </summary>
        [Key]
        public int IdRecibo { get; set; }


        //*************************************************************

        /// <summary>
        /// FK para o id do Jogo
        /// </summary>
        [ForeignKey(nameof(Jogo))]
        public int JogoFK { get; set; }
        public Jogos Jogo { get; set; }


        /// <summary>
        /// FK para o Utilizador Registado
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public UtilizadorRegistado Utilizador { get; set; }



    }
}
