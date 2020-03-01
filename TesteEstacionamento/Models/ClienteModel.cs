using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEstacionamento.Models
{
    public class ClienteModel
    {
        public ClienteModel(string placa)
        {
            Placa = placa;
            DataEntrada = DateTime.Now;
            DataSaida = DateTime.MinValue;
            Valor = "";
        }

        public int Id { get; set; }
        [Required]
        public string Placa { get; set; }
        [Display(Name = "Entrada")]
        public DateTime DataEntrada { get; set; }

        [Display(Name = "Saida")]
        public DateTime DataSaida { get; set; }

        public string Valor { get; set; }


        public void CalcularValor(TesteEstacionamentoContext context)
        {
            ValorModel valor = context
                                .Valores
                                .Where(v => v.InicioVigenciaDateTime <= DataEntrada
                                        && v.TerminoVigenciaDateTime >= DataEntrada)
                                .FirstOrDefault();

            var tempoPermanencia = DataSaida - DataEntrada;
            var dias = tempoPermanencia.Days;
            var horas = (dias * 24) + tempoPermanencia.Hours;
            var minutos = tempoPermanencia.Minutes;
            decimal valorTotal = 0; ;

            if (horas == 0)
            {
                valorTotal = minutos < 30 ? (valor.ValorInicial / 2) : valor.ValorInicial;
            }
            else
            {
                var considerarHoraAdicional = minutos <= 10 ? 0 : 1;
                //tirado 1 das horas pois é a hora inicial. A variavel considerarHoraAdicional é usada para considerar a tolerancia de 10 minutos 
                valorTotal = valor.ValorInicial + (valor.ValorAdicional * ((horas + considerarHoraAdicional) - 1));
            }

            Valor = valorTotal.ToString("C");

            // Valor = ;
        }

    }
}
