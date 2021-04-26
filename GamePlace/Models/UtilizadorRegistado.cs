using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamePlace.Models
{
    public class UtilizadorRegistado{


        public UtilizadorRegistado()
        {
            // inicializar a lista de Cães do Criador
            ListaDeUtilizadores = new HashSet<Recibo>();
        }
        /// <summary>
        /// identificador do utilizador
        /// </summary>
        [Key]
        public int IdUtilizador { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Nome { get; set; }

        /// <summary>
        /// Morada
        /// </summary>
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "A {0} não pode ter mais de {1} caracteres.")]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal
        /// </summary>
        [Required(ErrorMessage = "Deve escrever o {0}")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [Display(Name = "Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// Telemóvel
        /// </summary>
        [StringLength(14, MinimumLength = 9, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva, pf, um nº Telemóvel com 9 algarismos. Se quiser, pode acrescentar o indicativo nacional e o internacional. ")]
        [Display(Name = "Telemóvel")]
        public string Telemovel { get; set; } // ou se escreve o Telemóvel, ou o Email, ou os dois...

        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = "Deve escrever o {0}")]
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "o {0} introduzido não é válido")]
        [RegularExpression("((((aluno)|(es((tt)|(ta)|(gt))))[0-9]{4,5})|([a-z]+(.[a-z]+)*))@ipt.pt")]
        public string Email { get; set; } // ou se escreve o Telemóvel, ou o Email, ou os dois...

        // ############################################

        /// <summary>
        /// lista dos Jogos associados ao Utilizador
        /// </summary>
        public ICollection<Recibo> ListaDeUtilizadores { get; set; }








    }
}
