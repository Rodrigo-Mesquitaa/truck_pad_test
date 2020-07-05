using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transportadora.Entidades
{
    public class Terminal
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int IdVeiculo { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime Data { get; set; }
        public ICollection<Veiculo> Veiculos { get; set; }
    }
}
