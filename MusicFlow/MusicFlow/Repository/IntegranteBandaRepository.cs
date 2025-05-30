using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

                        await Mapper(dr, integrante);

                        listaDeIntegrantes.Add(integrante);
                    }
                }
            }
            return listaDeIntegrantes;
        }
        private async Task Mapper(SqlDataReader dr, IntegranteBanda integrante)
        {
            integrante.Id = (int)dr["Id"];
            integrante.Nome = dr["Nome"] as string;
            integrante.DataAniversario = (DateTime)dr["DataAniversario"];
            integrante.DataCadastro = (DateTime)dr["DataCadastro"];
            integrante.Status = (Status)Convert.ToInt32(dr["Status"]);
            integrante.Fone = dr["Fone"] as string;
            integrante.Funcoes = await CarregaListaFuncoes(integrante.Id ?? 0);
        }
        public async Task<Models.IntegranteBanda> Get(int id)
        {
            Models.IntegranteBanda integrante = new Models.IntegranteBanda();

            using(conn)
            {
                await conn.OpenAsync();

                using(cmd)
                {
                    cmd.CommandText = "SELECT Id, Nome, DataAniversario, DataCadastro, Fone, Status FROM IntegranteBanda WHERE Status = 0 AND Id = @Id;";

                    cmd.Parameters.AddWithValue("@Id", id);

                    SqlDataReader dr = await cmd.ExecuteReaderAsync();

                    if (await dr.ReadAsync())
                    {
                        await Mapper(dr, integrante);
                    }
                }
            }

            integrante.Funcoes = await CarregaListaFuncoes(id);

            return integrante;
        }
        public async Task Add(Models.IntegranteBanda integranteBanda)
        {
            int? idGerado = null;

            integranteBanda.DataCadastro = DateTime.Now;                

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "INSERT INTO IntegranteBanda (Nome, DataAniversario, DataCadastro, Fone, Status) VALUES (@Nome, @DataAniversario, @DataCadastro, @Fone, @Status); SELECT SCOPE_IDENTITY();";

                    MontaParametrosSql(cmd, integranteBanda);

                    idGerado = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                }
            }

            await RegistraFuncoes(idGerado ?? 0, integranteBanda.Funcoes);
        }
        public async Task<bool> Delete(int id)
        {
            int linhasAfetadas = 0;

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "UPDATE IntegranteBanda SET Status = 1 WHERE Id = @Id;";

                    cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;

                    linhasAfetadas = await cmd.ExecuteNonQueryAsync();
                }
            }
            return linhasAfetadas == 1;
        }
        public async Task<bool> Update(Models.IntegranteBanda integranteBanda)
        {
            int linhasAfetadas = 0;

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "UPDATE IntegranteBanda SET Nome = @Nome, DataCadastro = @DataCadastro, DataAniversario = @DataAniversario, Fone = @Fone) WHERE Id = @Id;";

                    MontaParametrosSql(cmd, integranteBanda);

                    linhasAfetadas = await cmd.ExecuteNonQueryAsync();
                }
            }
            return linhasAfetadas == 1;
        }
        private async Task RegistraFuncoes(int id, List<Models.Funcao> funcoes)
        {               
            using (conn)
            {
                await conn.OpenAsync();

                foreach (var item in funcoes)
                {
                    using (cmd)
                    {
                        cmd.CommandText = "INSERT INTO IntegranteFuncao (IdIntegrante, IdFuncao) VALUES (@IdIntegrante, @IdFuncao);";

                        cmd.Parameters.AddWithValue("@IdIntegrante", id);
                        cmd.Parameters.AddWithValue("@IdFuncao", item.Id);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
        }
        private async Task<List<Models.Funcao>> CarregaListaFuncoes(int id)
        {
            List<Funcao> listaDeFuncoes = new List<Funcao>();

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "SELECT Id, Nome, DataCadastro, Status FROM Funcao WHERE Id in (SELECT IdFuncao FROM IntegranteFuncao WHERE IdIntegrante = @Id) AND Status = 0;";

                    cmd.Parameters.AddWithValue("@Id", id);

                    SqlDataReader dr = await cmd.ExecuteReaderAsync();

                    while (await dr.ReadAsync())
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
        private void MontaParametrosSql(SqlCommand cmd, IntegranteBanda integranteBanda)
        {
            if (integranteBanda.Id != null)
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.VarChar)).Value = integranteBanda.Id;

            cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = integranteBanda.Nome;
            cmd.Parameters.Add(new SqlParameter("@DataCadastro", SqlDbType.DateTime)).Value = integranteBanda.DataCadastro;
            cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int)).Value = integranteBanda.Status;
            cmd.Parameters.Add(new SqlParameter("@DataAniversario", SqlDbType.DateTime)).Value = integranteBanda.DataAniversario;
            cmd.Parameters.Add(new SqlParameter("@Fone", SqlDbType.VarChar)).Value = integranteBanda.Fone;
        }
    }
}
