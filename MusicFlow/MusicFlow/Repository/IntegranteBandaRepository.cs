using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using MusicFlow.Models;

namespace MusicFlow.Repository
{
    internal class IntegranteBandaoRepository
    {
        private readonly SqlConnection conn;
        private readonly SqlCommand cmd;
        public IntegranteBandaoRepository()
        {
            conn = new SqlConnection(Configurations.Config.GetConnectionString("ConexaoPadrao"));
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        public async Task<List<Models.IntegranteBanda>> GetAll()
        {
            List<Models.IntegranteBanda> listaDeIntegrantes = new List<Models.IntegranteBanda>();

            using(conn)
            {
                await conn.OpenAsync();

                using(cmd)
                {
                    cmd.CommandText = "SELECT Id, Nome, DataAniversario, DataCadastro, Fone, Status FROM IntegranteBanda WHERE Status = 0;";

                    SqlDataReader dr = await cmd.ExecuteReaderAsync();

                    while (await dr.ReadAsync())
                    {
                        Models.IntegranteBanda integrante = new Models.IntegranteBanda();

                        Mapper(dr, integrante);

                        listaDeIntegrantes.Add(integrante);
                    }
                }
            }
            return listaDeIntegrantes;
        }
        private void Mapper(SqlDataReader dr, IntegranteBanda integrante)
        {
            integrante.Id = (int)dr["Id"];
            integrante.Nome = dr["Nome"] as string;
            integrante.DataAniversario = (DateTime)dr["DataAniversario"];
            integrante.DataCadastro = (DateTime)dr["DataCadastro"];
            integrante.Status = (Status)Convert.ToInt32(dr["Status"]);
            integrante.Fone = dr["Fone"] as string;
            integrante.Funcoes = CarregaListaFuncoes(integrante.Id ?? 0);
        }
        public Models.IntegranteBanda ListarPorId(int id)
        {
            string scriptSql =
                "SELECT Id, Nome, DataAniversario, DataCadastro, Fone, Status " +
                "FROM IntegranteBanda " +
                "WHERE Status = 0 " +
                "AND Id = @Id;";

            IntegranteBanda integrante = null;

            using
            (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using
                (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        integrante = new IntegranteBanda();

                        integrante.Id = (int)dr["Id"];
                        integrante.Nome = dr["Nome"] as string;
                        integrante.Fone = dr["Fone"] as string;
                        integrante.DataCadastro = (DateTime)dr["DataCadastro"];
                        integrante.DataAniversario = (DateTime)dr["DataAniversario"];
                        integrante.Status = (Status)Convert.ToInt32(dr["Status"]);
                    }
                }
            }

            integrante.Funcoes = carregaListaFuncoes(id);

            return integrante;
        }
        public Models.IntegranteBanda Adicionar(Models.IntegranteBanda integranteBanda)
        {
            int? idGerado = null;

            integranteBanda.DataCadastro = DateTime.Now;

            string scriptSql =
                "INSERT INTO IntegranteBanda (Nome, DataAniversario, DataCadastro, Fone, Status) " +
                "VALUES (@Nome, @DataAniversario, @DataCadastro, @Fone, @Status); " +
                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = integranteBanda.Nome;
                    cmd.Parameters.Add(new SqlParameter("@DataCadastro", SqlDbType.DateTime)).Value =  integranteBanda.DataCadastro;
                    cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int)).Value =  integranteBanda.Status;
                    cmd.Parameters.Add(new SqlParameter("@DataAniversario", SqlDbType.DateTime)).Value = integranteBanda.DataAniversario;
                    cmd.Parameters.Add(new SqlParameter("@Fone", SqlDbType.VarChar)).Value = integranteBanda.Fone;

                    idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            registraFuncoes(idGerado ?? 0, integranteBanda.Funcoes);

            return ListarPorId(idGerado ?? 0);
        }
        public Models.IntegranteBanda Excluir(int id)
        {
            string scriptSql =
                "UPDATE IntegranteBanda SET Status = 1 WHERE Id = @Id;";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
            return ListarPorId(id);
        }
        public Models.IntegranteBanda Alterar(int id, Models.IntegranteBanda integranteBanda)
        {
            IntegranteBanda integranteAlterado = ListarPorId(id);

            if (integranteAlterado == null) { return null; }

            string scriptSql =
                "UPDATE IntegranteBanda " +
                "SET Nome = @Nome, DataCadastro = @DataCadastro, DataAniversario = @DataAniversario, Fone = @Fone) " +
                "WHERE Id = @Id;";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", integranteBanda.Nome);
                    cmd.Parameters.AddWithValue("@DataCadastro", integranteBanda.DataCadastro);
                    cmd.Parameters.AddWithValue("@DataAniversario", integranteBanda.DataAniversario);
                    cmd.Parameters.AddWithValue("@DataAniversario", integranteBanda.Fone);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
            return ListarPorId(id);
        }
        private void RegistraFuncoes(int id, List<Models.Funcao> funcoes)
        {
            string scriptSql =
                "INSERT INTO IntegranteFuncao (IdIntegrante, IdFuncao) " +
                "VALUES (@IdIntegrante, @IdFuncao);";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                foreach (var item in funcoes)
                {
                    using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdIntegrante", id);
                        cmd.Parameters.AddWithValue("@IdFuncao", item.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        private List<Models.Funcao> CarregaListaFuncoes(int id)
        {
            List<Funcao> listaDeFuncoes = new List<Funcao>();

            string scriptSql =
                "SELECT Id, Nome, DataCadastro, Status FROM Funcao WHERE Id in (SELECT IdFuncao FROM IntegranteFuncao WHERE IdIntegrante = @Id) AND Status = 0;";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        listaDeFuncoes.Add(new Funcao
                        {
                            Id = (int)dr["Id"],
                            Nome = (string)dr["Nome"],
                            DataCadastro = (DateTime)dr["DataCadastro"],
                            Status = (Status)Convert.ToInt32(dr["Status"])
                        });
                    }
                }
            }

            return listaDeFuncoes;
        }
    }
}
