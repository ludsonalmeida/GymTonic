using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GymTonicWeb.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string NomeSocial { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório.")]
        [DataType(DataType.EmailAddress, ErrorMessage="Neste campo deve ser inserido um email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatório.")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "A Senha deve conter entre 4 e 10 dígitos.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo Altura é obrigatório.")]
        [Range(0.3, 3.0, ErrorMessage = "A altura deve ser digitada em metros entre 0.3m a 3.0m")]
        public double Altura { get; set; }

        [Required(ErrorMessage = "O campo Peso é obrigatório.")]
        [Range(1, 3)]
        public int Peso { get; set; }

        public int ProfessorID { get; set; }
        public Professor Professor { get; set; }



        
    }
}