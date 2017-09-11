using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiiSolution.ZiiSensor.Dominio.Entidade;
using ZiiSolution.ZiiSensor.Dominio.Interface;
using ZiiSolution.ZiiSensor.Repositorio;
using ZiiSolution.ZiiSensor.Repositorio.Repositorio;

namespace ZiiSolution.ZiiSensor.Negocio
{
    public class TemperaturaNegocio
    {
        private TemperaturaRepositorio  _dalTemperatura;

        private TemperaturaRepositorio DalTemperatura
        {
            get
            {
                if (_dalTemperatura == null) _dalTemperatura = new TemperaturaRepositorio();
                return _dalTemperatura;
            }
        }

        //public ServicoConsulta(ILogger Logger, IServicoTratamentoDados ServicoTratamentoDados)
        //{
        //    this._servicoTratamentoDados = ServicoTratamentoDados;
        //    this._logger = Logger;

        //    InitializeComponent();
        //}

        //public int GetTemperatura(int id)
        //{

        //    return 0;
        //}       

        public void Incluir(Temperatura entidade)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.ID = entidade.ID;
            temperatura.IDDispositivo = 2;
            temperatura.DataHora = entidade.DataHora;
            temperatura.TemperaturaAtual = entidade.TemperaturaAtual;
            temperatura.TemperaturaMaxima = entidade.TemperaturaMaxima;
            temperatura.TemperaturaMinima = entidade.TemperaturaMinima;
            temperatura.Umidade = entidade.Umidade;


           DalTemperatura.Incluir(temperatura);
        }

        public Dominio.Entidade.Temperatura GetTemperatura(int id)
        {
            return this.DalTemperatura.GetTemperatura(id);
        }

        public List<Dominio.Entidade.Temperatura> GetAllTemperatura()
        {
            return DalTemperatura.GetAllTemperatura();
        }

    }
}
