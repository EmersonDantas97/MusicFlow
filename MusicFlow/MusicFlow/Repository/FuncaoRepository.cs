using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using MusicFlow.Models;

namespace MusicFlow.Repository
{
    internal class FuncaoRepository
    {
        private readonly string _conexao;
        public FuncaoRepository()
        {
            _conexao = ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString;
        }
        public List<Funcao> ListarTodas()
        {
            List<Funcao> listaDeFuncoes = new List<Funcao>();

            string scriptSql =
                "SELECT Id, Nome, DataCadastro, Status FROM Funcao WHERE Status = 0;";

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
                        listaDeFuncoes.Add(new Funcao
                        {
                            Id = (int)dr["Id"],
                            Nome = dr["Nome"] as string,
                            DataCadastro = (DateTime)dr["DataCadastro"],
                            Status = (Status)Convert.ToInt32(dr["Status"])
                        });
                    }
                }
            }

            return listaDeFuncoes;
        }
        public Funcao ListarPorId(int id)
        {
            string scriptSql =
                "SELECT Id, Nome, DataCadastro, Status FROM Funcao WHERE Status = 0 and Id = @Id;";

            Funcao funcao = null;

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
                        funcao = new Funcao();

                        funcao.Id = (int)dr["Id"];
                        funcao.Nome = dr["Nome"] as string;
                        funcao.DataCadastro = (DateTime)dr["DataCadastro"];
                        funcao.Status = (Status)Convert.ToInt32(dr["Status"]);
                    }
                }
            }

            return funcao;
        }
        public Funcao Adicionar(Funcao funcao)
        {
            int? idGerado = null;

            string scriptSql =
                "INSERT INTO Funcao (Nome, DataCadastro, Status) " +
                "VALUES (@Nome, @DataCadastro, @Status); " +
                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcao.Nome);
                    cmd.Parameters.AddWithValue("@DataCadastro", funcao.DataCadastro);
                    cmd.Parameters.AddWithValue("@Status", funcao.Status);

                    idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return ListarPorId(idGerado ?? 0);
        }
        public Funcao Excluir(int id)
        {
            string scriptSql =
                "UPDATE Funcao SET Status = 1 WHERE Id = @Id;";

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
        public Funcao Alterar(int id, Funcao funcao)
        {
            Funcao funcaoAlterada = ListarPorId(id);

            if (funcaoAlterada == null) { return null; }

            string scriptSql =
                "UPDATE Funcao " +
                "SET Nome = @Nome, DataCadastro = @DataCadastro) " +
                "WHERE Id = @Id;";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcao.Nome);
                    cmd.Parameters.AddWithValue("@DataCadastro", funcao.DataCadastro);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
            return ListarPorId(id);
        }

    }
}
