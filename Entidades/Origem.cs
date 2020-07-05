using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transportadora.Entidades
{
    public class Origem       
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int IdMotorista { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public float Latitude { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public float Longitude { get; set; }

        public Motorista Motorista { get; set; }
    }
}
