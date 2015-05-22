using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GymTonicWeb.Models
{
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage="O Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings=true)]
        public string NomeSocial { get; set; }

        [Required(AllowEmptyStrings=true)]
        public string Endereco { get; set; }

        [Required(ErrorMessage="O Email é obrigatório.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Neste campo deve ser inserido um email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage="A Senha é obrigatório.")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength=4, ErrorMessage="A Senha deve conter entre 4 e 10 dígitos.")]
        public string Senha { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

        public Professor()
        {
            this.Usuarios = new List<Usuario>();
        }
    }
}