using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MusicFlow.Repository
{
    internal class FuncaoRepository
    {
        private readonly SqlConnection conn;
        private readonly SqlCommand cmd;
        public FuncaoRepository(string connectionString)
        {
            conn = new SqlConnection(Configurations.Config.GetConnectionString(connectionString));
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        public async Task<List<Models.Funcao>> GetAll()
        {
            List<Models.Funcao> listaDeFuncoes = new List<Models.Funcao>();

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "SELECT Id, Nome, DataCadastro, Status FROM Funcao WHERE Status = 0;";

                    SqlDataReader dr = await cmd.ExecuteReaderAsync();

                    while (await dr.ReadAsync())
                    {
                        Models.Funcao funcao = new Models.Funcao();

                        Mapper(dr, funcao);

                        listaDeFuncoes.Add(funcao);
                    }
                }
            }
            return listaDeFuncoes;
        }
        public async Task<Models.Funcao> GetById(int id)
        {
            Models.Funcao funcao = new Models.Funcao();

            using (conn)
            {
                await conn.OpenAsync();

                using(cmd)
                {
                    cmd.CommandText = "SELECT Id, Nome, DataCadastro, Status FROM Funcao WHERE Status = 0 and Id = @Id;";

                    cmd.Parameters.AddWithValue("@Id", id);

                    SqlDataReader dr = await cmd.ExecuteReaderAsync();

                    if (await dr.ReadAsync())
                    {
                        Mapper(dr, funcao);
                    }
                }
            }

            return funcao;
        }
        public async Task Add(Models.Funcao funcao)
        {              
            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "INSERT INTO Funcao (Nome, DataCadastro, Status) VALUES (@Nome, @DataCadastro, @Status);SELECT SCOPE_IDENTITY();";

                    AdicionaParametrosSqlScript(cmd, funcao);

                    funcao.Id = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                }
            }
        }
        public async Task<bool> Delete(int id)
        {
            int linhasAfetadas = 0;

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "UPDATE Funcao SET Status = 1 WHERE Id = @Id;";

                    cmd.Parameters.AddWithValue("@Id", id);

                    linhasAfetadas = await cmd.ExecuteNonQueryAsync();
                }
            }
            return linhasAfetadas == 1;
        }
        public async Task<bool> Update(Models.Funcao funcao)
        {
            int linhasAfetadas = 0;

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "UPDATE Funcao SET Nome = @Nome, DataCadastro = @DataCadastro WHERE Id = @Id;";

                    AdicionaParametrosSqlScript(cmd, funcao);

                    linhasAfetadas = await cmd.ExecuteNonQueryAsync();
                }
            }
            return linhasAfetadas == 1;
        }
        private void AdicionaParametrosSqlScript(SqlCommand cmd, Models.Funcao funcao)
        {
            if(funcao.Id != null)
                cmd.Parameters.AddWithValue("@Id", funcao.Id);

            cmd.Parameters.AddWithValue("@Nome", funcao.Nome);
            cmd.Parameters.AddWithValue("@DataCadastro", funcao.DataCadastro);
            cmd.Parameters.AddWithValue("@Status", funcao.Status);
        }
        private void Mapper(SqlDataReader dr, Models.Funcao funcao)
        {
            funcao.Id = (int)dr["Id"];
            funcao.Nome = dr["Nome"] as string;
            funcao.DataCadastro = (DateTime)dr["DataCadastro"];
            funcao.Status = (Models.Status)Convert.ToInt32(dr["Status"]);
        }
    }
}
