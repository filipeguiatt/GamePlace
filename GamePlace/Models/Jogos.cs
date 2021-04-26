using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GamePlace.Models
{
    public class Jogos{


        public Jogos()
        {
            // inicializar a lista de Criadores do cão
            ListaUtilizadores = new HashSet<Recibo>();
        }

        /// <summary>
        /// Identificador de cada Jogo
        /// </summary>
        [Key]
        public int IdJogo { get; set; }

        /// <summary>
        /// Nome do Jogo
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descricao do Jogo
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Data de Lançamento do Jogo
        /// </summary>
        public string AnoLancamento { get; set; }

        /// <summary>
        /// Genero do Jogo
        /// </summary>
        public string Genero { get; set; }

        /// <summary>
        /// Preco do Jogo
        /// </summary>
        public string Preco { get; set; }

        /// <summary>
        /// Classificação do Jogo
        /// </summary>
        public string Classificacao { get; set; }

        public ICollection<Recibo> ListaUtilizadores { get; set; }
    }
}
