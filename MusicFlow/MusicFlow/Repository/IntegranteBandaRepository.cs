using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using MusicFlow.Models;

namespace MusicFlow.Repository
{
    internal class IntegranteBandaoRepository
    {
        private readonly string _conexao;
        public IntegranteBandaoRepository()
        {
            _conexao = ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString;
        }
        public List<IntegranteBanda> ListarTodos()
        {
            List<IntegranteBanda> listaDeIntegrantes = new List<IntegranteBanda>();

            string scriptSql =
                "SELECT Id, Nome, DataAniversario, DataCadastro, Fone, Status " +
                "FROM IntegranteBanda " +
                "WHERE Status = 0;";

            using
            (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using
                (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        IntegranteBanda integrante = new IntegranteBanda();

                        integrante.Id = (int)dr["Id"];
                        integrante.Nome = dr["Nome"] as string;
                        integrante.DataAniversario = (DateTime)dr["DataAniversario"];
                        integrante.DataCadastro = (DateTime)dr["DataCadastro"];
                        integrante.Status = (Status)Convert.ToInt32(dr["Status"]);
                        integrante.Fone = dr["Fone"] as string;
                        integrante.Funcoes = carregaListaFuncoes(integrante.Id ?? 0);

                        listaDeIntegrantes.Add(integrante);
                    }
                }
            }

            return listaDeIntegrantes;
        }
        public IntegranteBanda ListarPorId(int id)
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
        public IntegranteBanda Adicionar(IntegranteBanda integranteBanda)
        {
            int? idGerado = null;

            string scriptSql =
                "INSERT INTO IntegranteBanda (Nome, DataAniversario, DataCadastro, Fone, Status) " +
                "VALUES (@Nome, @DataAniversario, @DataCadastro, @Fone, @Status); " +
                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", integranteBanda.Nome);
                    cmd.Parameters.AddWithValue("@DataCadastro", integranteBanda.DataCadastro);
                    cmd.Parameters.AddWithValue("@Status", integranteBanda.Status);
                    cmd.Parameters.AddWithValue("@DataAniversario", integranteBanda.DataAniversario);
                    cmd.Parameters.AddWithValue("@Fone", integranteBanda.Fone);

                    idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            registraFuncoes(idGerado ?? 0, integranteBanda.Funcoes);

            return ListarPorId(idGerado ?? 0);
        }
        public IntegranteBanda Excluir(int id)
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
        public IntegranteBanda Alterar(int id, IntegranteBanda integranteBanda)
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
        private void registraFuncoes(int id, List<Funcao> funcoes)
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
        private List<Funcao> carregaListaFuncoes(int id)
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
