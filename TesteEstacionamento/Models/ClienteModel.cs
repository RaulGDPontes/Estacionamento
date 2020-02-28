using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEstacionamento.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required]
        public string Placa { get; set; }
        [Display(Name = "Entrada")]
        public DateTime DataEntrada { get; set; }

        [Display(Name = "Saida")]
        public DateTime HoraSaida { get; set; }
    }
}
