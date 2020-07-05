using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Transportadora.Entidades
{
    public class Veiculo
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Nome { get; set;}
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool Carregado { get; set; }
        public ICollection<Motorista> Motoristas { get; set; }
        public Terminal Terminal { get; set; }

    }
}