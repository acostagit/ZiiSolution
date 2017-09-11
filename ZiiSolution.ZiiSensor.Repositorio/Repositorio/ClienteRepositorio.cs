using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ZiiSolution.ZiiSensor.Dominio.Entidade;

namespace ZiiSolution.ZiiSensor.Repositorio.Cliente
{
    public class ClienteRepositorio
    {
        //private readonly Repositorio.TemperaturaRepositorio

        //private readonly IRepositorioBase<Dominio.Entidade.Cliente> _clienteRepositorio;

        public void Alterar(Dominio.Entidade.Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public void BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Dominio.Entidade.Cliente Incluir(Dominio.Entidade.Cliente cliente)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {

                //if (cliente.NomeFantasia == null) cliente.NomeFantasia = string.Empty;
                //if (cliente.Complemento == null) cliente.Complemento = string.Empty;

                //sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.CommandText = "pr_ClienteIncluir";

                //sqlCommand.Parameters.AddWithValue("@PessoaTipoID", cliente.PessoaTipoID);
                //sqlCommand.Parameters.AddWithValue("@Nome", cliente.Nome);
                //sqlCommand.Parameters.AddWithValue("@NomeFantasia", cliente.NomeFantasia);
                //sqlCommand.Parameters.AddWithValue("@CnpjCpf", cliente.CnpjCpf);
                //sqlCommand.Parameters.AddWithValue("@InscricaoMunicipal", cliente.InscricaoMunicipal);
                //sqlCommand.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                //sqlCommand.Parameters.AddWithValue("@CEP", cliente.CEP);
                //sqlCommand.Parameters.AddWithValue("@CidadeID", cliente.CidadeID);
                //sqlCommand.Parameters.AddWithValue("@EstadoID", cliente.EstadoID);
                //sqlCommand.Parameters.AddWithValue("@TelefonePrefixo", cliente.TelefonePrefixo);
                //sqlCommand.Parameters.AddWithValue("@TelefoneNumero", cliente.TelefoneNumero);
                //sqlCommand.Parameters.AddWithValue("@Email", cliente.Email);
                //sqlCommand.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                //sqlCommand.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                //sqlCommand.Parameters.AddWithValue("@Numero", cliente.Numero);
                //sqlCommand.Parameters.AddWithValue("@DataCriacao", cliente.DataCriacao);
                //sqlCommand.Parameters.AddWithValue("@UsuarioCriacao", cliente.UsuarioCriacao);

                //using (SqlConnection sqlConnection = new SqlConnection(ConsultarStringConexao()))
                //{
                //    sqlCommand.Connection = sqlConnection;
                //    sqlConnection.Open();
                //    cliente.ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
                //}
            }

            return cliente;
        }

        public void InserirOuAtualizar(Dominio.Entidade.Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public void ListarTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Dominio.Entidade.Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public void Visualizar(Dominio.Entidade.Cliente entidade)
        {
            throw new NotImplementedException();
        }
        
    }
}
