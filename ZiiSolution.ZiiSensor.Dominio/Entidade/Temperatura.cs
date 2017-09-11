using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSolution.ZiiSensor.Dominio.Entidade
{
    public class Temperatura
    {
        public int ID { get; set; }

        public DateTime DataHora { get; set; }

        public int IDDispositivo { get; set; }

        public int TemperaturaMaxima { get; set; }

        public int TemperaturaMinima { get; set; }

        public int TemperaturaAtual { get; set; }

        public string Umidade { get; set; }
    }
}
