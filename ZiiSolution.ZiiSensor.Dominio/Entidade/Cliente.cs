using System;

namespace ZiiSolution.ZiiSensor.Dominio.Entidade
{
    public class Cliente 
    {
        public int ID { get; set; }

        public string Cidade { get; set; }
       
        public string Endereo { get; set; }        

        public int IDEstado { get; set; }

        public int IDTipoCliente { get; set; }

        public string Nome { get; set; }

    }
}
