using MusicFlow.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicFlow.Repository
{
    internal class EventoRepository
    {
        private readonly string _conexao;
        public EventoRepository()
        {
            _conexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString;
        }

        #region "Métodos para abstação"
        private void registraSetlist(int idEvento, List<Musica> setList)
        {
            string scriptSql =
                "Insert into EventoSetlist (IdEvento, IdMusica) Values (@IdEvento, @IdMusica);Select scope_identity();"

            foreach (var musica in setList)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@IdEvento", SqlDbType.Int)).Value = idEvento;
                        cmd.Parameters.Add(new SqlParameter("@IdMusica", SqlDbType.Int)).Value = musica.Id;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        private void registraBanda(int IdEvento, List<IntegranteBanda> banda)
        {
            string scriptSql =
                "Insert into EventoBanda (IdEvento, IdIntegranteFuncao) Values (@IdEvento, @IdIntegranteFuncao); select scope_identity();";

            foreach (var integrante in banda)
            {
                using (SqlConnection conn = new SqlConnection(_conexao))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("IdEvento", SqlDbType.Int)).Value = IdEvento;
                        cmd.Parameters.Add(new SqlParameter("IdIntegranteFuncao", SqlDbType.Int)).Value = integrante.Id;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        #endregion
        internal Evento Adicionar(Evento evento)
        {
            string scriptSql =
                "Insert into Evento (Nome, DataCadastro, DataEvento, HoraEvento, Observacao, Status) " +
                "Values (@Nome, @DataCadastro, @DataEvento, @HoraEvento, @Observacao, @Status); " +
                "Select scope_identity(); ";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = evento.Nome;
                    cmd.Parameters.Add(new SqlParameter("@DataCadastro", SqlDbType.DateTime)).Value = evento.DataCadastro;
                    cmd.Parameters.Add(new SqlParameter("@DataEvento", SqlDbType.DateTime)).Value = evento.DataEvento;
                    cmd.Parameters.Add(new SqlParameter("@HoraEvento", SqlDbType.Time)).Value = evento.HoraEvento;
                    cmd.Parameters.Add(new SqlParameter("@Observacao", SqlDbType.VarChar)).Value = evento.Observacao;
                    cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int)).Value = evento.Status;

                    evento.Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            registraSetlist(evento.Id ?? 0, evento.SetList);
            registraBanda(evento.Id ?? 0, evento.Banda);

            return evento;
        }
        internal Evento Alterar(int id, Evento evento)
        {
            throw new NotImplementedException();
        }
        internal Evento Excluir(int id)
        {
            throw new NotImplementedException();
        }
        internal Evento ListarPorId(int id)
        {
            throw new NotImplementedException();
        }
        internal List<Evento> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
