using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEstacionamento.Models
{
    public class ValorModel
    {
        public int Id { get; set; }
        [Display(Name = "Inicio da Vigência")]
        public string InicioVigencia { get; set; }

        [Display(Name = "Término da Vigência")]
        public string TerminoVigencia { get; set; }

        [Display(Name = "Valor Inicial")]
        public decimal ValorInicial { get; set; }

        [Display(Name = "Valor Adicional")]
        public decimal ValorAdicional { get; set; }

        [NotMapped]
        [Display(Name = "Inicio da Vigencia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime InicioVigenciaDateTime
        {
            get
            {
                return ConverterData(InicioVigencia);
            }
        }

        [NotMapped]
        [Display(Name = "Termino da Vigência")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TerminoVigenciaDateTime
        {
            get
            {
                return ConverterData(TerminoVigencia);
            }
        }


        private DateTime ConverterData(string pData)
        {
            try
            {
                var dataArray = pData.Split('-');
                return new DateTime(Convert.ToInt16(dataArray[0]), Convert.ToInt16(dataArray[1]), Convert.ToInt16(dataArray[2]));
            }
            catch
            {
                return DateTime.MinValue;
            }
        }


    }
}
