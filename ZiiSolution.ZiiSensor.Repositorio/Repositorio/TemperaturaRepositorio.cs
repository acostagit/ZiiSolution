using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiiSolution.ZiiSensor.Dominio.Entidade;

namespace ZiiSolution.ZiiSensor.Repositorio.Repositorio
{
    public class TemperaturaRepositorio: Base
    {
        public void Incluir(Temperatura temperatura)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "spr_TemperaturaIncluir";

                //sqlCommand.Parameters.AddWithValue("@PessoaTipoID", temperatura.PessoaTipoID);
                //sqlCommand.Parameters.AddWithValue("@Nome", temperatura.DataHora);
                sqlCommand.Parameters.AddWithValue("@IDDispositivo", temperatura.IDDispositivo);
                sqlCommand.Parameters.AddWithValue("@TemperaturaAtual", temperatura.TemperaturaAtual);
                sqlCommand.Parameters.AddWithValue("@TemperaturaMaxima", temperatura.TemperaturaMaxima);
                sqlCommand.Parameters.AddWithValue("@TemperaturaMinima", temperatura.TemperaturaMinima);
                sqlCommand.Parameters.AddWithValue("@Umidade", temperatura.Umidade);

                using (SqlConnection sqlConnection = new SqlConnection(ConsultarStringConexao()))
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                   Convert.ToInt32(sqlCommand.ExecuteScalar());
                    //temperatura.ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
            }            
        }
        
        public Dominio.Entidade.Temperatura GetTemperatura(int id)
        {
            Dominio.Entidade.Temperatura temperatura = new Temperatura();

           // T obj = default(T);
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "spr_TemperaturaConsultarPorID";

                sqlCommand.Parameters.AddWithValue("@ID", id);

                using (SqlConnection sqlConnection = new SqlConnection(ConsultarStringConexao()))
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.Read())
                    {
                        temperatura = ConverterDataReaderParaObjeto(dr);
                     //   obj = CarregarTipo<T>(dr);
                    }

                }

            }

            return temperatura;
        }

        public List<Dominio.Entidade.Temperatura> GetAllTemperatura()
        {
            List<Dominio.Entidade.Temperatura> lista = new List<Temperatura>();

           

            // T obj = default(T);
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "spr_TemperaturaConsultar";

                using (SqlConnection sqlConnection = new SqlConnection(ConsultarStringConexao()))
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        Temperatura temperatura = new Temperatura();
                        temperatura = ConverterDataReaderParaObjeto(dr);
                        lista.Add(temperatura);

                    }
                }
            }

            return lista;
        }


        private Temperatura ConverterDataReaderParaObjeto(SqlDataReader dr)
        {
            Dominio.Entidade.Temperatura temperatura = new Temperatura();
            temperatura.ID = Convert.ToInt32(dr["ID"]);
            temperatura.IDDispositivo = Convert.ToInt32(dr["IDDispositivo"]);
            temperatura.DataHora = Convert.ToDateTime(dr["DataHora"]);
            temperatura.TemperaturaAtual = Convert.ToInt32(dr["TemperaturaAtual"]);
            temperatura.TemperaturaMaxima = Convert.ToInt32(dr["TemperaturaMaxima"]);
            temperatura.TemperaturaMinima = Convert.ToInt32(dr["TemperaturaMinima"]);
            temperatura.Umidade = dr["Umidade"].ToString();
            return temperatura;
        }
    }
}
