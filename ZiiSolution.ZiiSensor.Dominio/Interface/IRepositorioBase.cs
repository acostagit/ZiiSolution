using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSolution.ZiiSensor.Dominio.Interface
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Incluir(Dominio.Entidade.Temperatura entidade);
        int GetTemperatura(Dominio.Entidade.Temperatura temperatura);
    }
}
