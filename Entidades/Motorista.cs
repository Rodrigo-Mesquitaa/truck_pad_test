using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transportadora.Entidades
{
    public class Motorista
    {
        [Key]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 1 e 60 caracteres")]
        [MinLength(1, ErrorMessage = "este campo deve conter apenas 1")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        //[Range(18, int.MinValue, ErrorMessage = " A idade deve ser maior de 18 anos ")]
        public int Idade { get; set; }

        [MinLength(1, ErrorMessage = "Este campo deve ser informado apenas F ou M")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool PossuirVeiculo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string TipoCNH { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int IdVeiculo { get; set; }

        public Veiculo Veiculo { get; set; }
        public ICollection<Origem> Origens { get; set; }
        public ICollection<Destino> Destinos { get; set; }

    }
}
