using MusicFlow.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace MusicFlow.Repository
{
    internal class MusicaRepository
    {
        private readonly string _conexao;
        private readonly string _diretorioLog;
        public MusicaRepository()
        {
            _conexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString;
            _diretorioLog = System.Configuration.ConfigurationManager.AppSettings["logPath"];
        }
        public List<Musica> ListarTodas()
        {
            try
            {
                List<Musica> listaDeMusicas = new List<Musica>();

                string scriptSql =
                    "select Id, Nome, Interprete, Versao, DataCadastro, Observacao, BPM, Compasso, Tom, TemVS, TomOriginal, LinkVideo, LinkCifra, Status " +
                    "from musica " +
                    "where Status = 0;";

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
                            Musica integrante = new Musica();

                            integrante.Id = (int)dr["Id"];
                            integrante.Nome = dr["Nome"].ToString();
                            integrante.DataCadastro = (DateTime)dr["DataCadastro"];
                            integrante.Status = (Status)Convert.ToInt32(dr["Status"]);
                            integrante.VozPrincipal = (int)dr["VozPrincipal"];
                            integrante.Bpm = (int)dr["Bpm"];
                            integrante.Versao = dr["Versao"].ToString();
                            integrante.Compasso = dr["Compasso"].ToString();
                            integrante.Tom = dr["Tom"].ToString();
                            integrante.LinkVideo = dr["LinkVideo"].ToString();
                            integrante.LinkCifra = dr["LinkCifra"].ToString();
                            integrante.Observacao = dr["Observacao"].ToString();
                            integrante.TomOriginal = (TomOriginal)dr["LinkCifra"];
                            integrante.TemVs = (TemVs)dr["TemVs"];

                            listaDeMusicas.Add(integrante);
                        }
                    }
                }

                return listaDeMusicas;
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(_diretorioLog, true))
                {
                    sw.Write("Data e Hora: ");
                    sw.WriteLine(DateTime.Now.ToString("G"));
                    sw.Write("Erro: ");
                    sw.WriteLine(ex.Message);
                    sw.Write("StackTrace: ");
                    sw.WriteLine(ex.StackTrace);
                    sw.WriteLine();
                }

                return null;
            }
        }
        public Musica ListarPorId(int id)
        {
            Musica musica = null;

            string scriptSql =
                "select Id, Nome, Interprete, Versao, DataCadastro, Observacao, BPM, Compasso, Tom, TemVS, TomOriginal, LinkVideo, LinkCifra, Status " +
                "from musica " +
                "where Status = 0 " +
                "and Id = @Id;";

            using
            (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using
                (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        musica = new Musica();

                        musica.Id = (int)dr["Id"];
                        musica.Nome = dr["Nome"].ToString();
                        musica.DataCadastro = (DateTime)dr["DataCadastro"];
                        musica.Status = (Status)Convert.ToInt32(dr["Status"]);
                        musica.VozPrincipal = (int)dr["VozPrincipal"];
                        musica.Bpm = (int)dr["Bpm"];
                        musica.Versao = dr["Versao"].ToString();
                        musica.Compasso = dr["Compasso"].ToString();
                        musica.Tom = dr["Tom"].ToString();
                        musica.LinkVideo = dr["LinkVideo"].ToString();
                        musica.LinkCifra = dr["LinkCifra"].ToString();
                        musica.Observacao = dr["Observacao"].ToString();
                        musica.TomOriginal = (TomOriginal)dr["LinkCifra"];
                        musica.TemVs = (TemVs)dr["TemVs"];
                    }
                }
            }

            return musica;
        }
        public int Adicionar(Musica musica)
        {
            string scriptSql =
                "INSERT INTO Musica (Nome, VozPrincipal, Versao, DataCadastro, Observacao, BPM, Compasso, Tom, TemVS, TomOriginal, LinkVideo, LinkCifra, Status) " +
                "VALUES (@Nome, @VozPrincipal, @Versao, @DataCadastro, @Observacao, @BPM, @Compasso, @Tom, @TemVS, @TomOriginal, @LinkVideo, @LinkCifra, @Status); " +
                "SELECT Scope_Identity();";

            int idGerado = 0;

            using
            (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using
                (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = musica.Nome;
                    cmd.Parameters.Add(new SqlParameter("@VozPrincipal", SqlDbType.Int)).Value = musica.VozPrincipal;
                    cmd.Parameters.Add(new SqlParameter("@Versao", SqlDbType.VarChar)).Value = musica.Versao;
                    cmd.Parameters.Add(new SqlParameter("@DataCadastro", SqlDbType.DateTime)).Value = musica.DataCadastro;
                    cmd.Parameters.Add(new SqlParameter("@Observacao", SqlDbType.VarChar)).Value = musica.Observacao;
                    cmd.Parameters.Add(new SqlParameter("@BPM", SqlDbType.Int)).Value = musica.Bpm;
                    cmd.Parameters.Add(new SqlParameter("@TemVS", SqlDbType.Int)).Value = musica.TemVs;
                    cmd.Parameters.Add(new SqlParameter("@Tom", SqlDbType.VarChar)).Value = musica.Tom;
                    cmd.Parameters.Add(new SqlParameter("@Compasso", SqlDbType.VarChar)).Value = musica.Compasso;
                    cmd.Parameters.Add(new SqlParameter("@TomOriginal", SqlDbType.Int)).Value = musica.TomOriginal;
                    cmd.Parameters.Add(new SqlParameter("@LinkVideo", SqlDbType.VarChar)).Value = musica.LinkVideo;
                    cmd.Parameters.Add(new SqlParameter("@LinkCifra", SqlDbType.VarChar)).Value = musica.LinkCifra;
                    cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int)).Value = musica.Status;

                    musica.Id = Convert.ToInt32(cmd.ExecuteScalar());

                    idGerado = musica.Id ?? 0;
                }
            }

            return idGerado;
        }
        public Musica Excluir(int id)
        {
            string scriptSql =
                "UPDATE Musica SET Status = 1 WHERE Id = @Id;";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }

            return ListarPorId(id);
        }
        public Musica Alterar(int id, Musica musica)
        {
            Musica musicaAlterada = ListarPorId(id);

            if (musicaAlterada == null)
                return null;

            string scriptSql =
                "UPDATE Musica " +
                "SET Nome = @Nome, " +
                "DataCadastro = @DataCadastro, " +
                "Status = @Status, " +
                "VozPrincipal = @VozPrincipal, " +
                "Bpm = @Bpm, " +
                "Versao = @Versao, " +
                "Compasso = @Compasso, " +
                "Tom = @Tom, " +
                "LinkVideo = @LinkVideo, " +
                "LinkCifra = @LinkCifra, " +
                "TomOriginal = @TomOriginal, " +
                "TemVs = @TemVs, " +
                "Observacao = @Observacao) " +
                "WHERE Id = @Id;";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(scriptSql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;
                    cmd.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar)).Value = musica.Nome;
                    cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int)).Value = musica.Status;
                    cmd.Parameters.Add(new SqlParameter("@DataCadastro", SqlDbType.DateTime)).Value = musica.DataCadastro;
                    cmd.Parameters.Add(new SqlParameter("@VozPrincipal", SqlDbType.Int)).Value = musica.VozPrincipal;
                    cmd.Parameters.Add(new SqlParameter("@Bpm", SqlDbType.Int)).Value = musica.Bpm;
                    cmd.Parameters.Add(new SqlParameter("@Versao", SqlDbType.VarChar)).Value = musica.Versao;
                    cmd.Parameters.Add(new SqlParameter("@Compasso", SqlDbType.VarChar)).Value = musica.Compasso;
                    cmd.Parameters.Add(new SqlParameter("@Tom", SqlDbType.VarChar)).Value = musica.Tom;
                    cmd.Parameters.Add(new SqlParameter("@LinkVideo", SqlDbType.VarChar)).Value = musica.LinkVideo;
                    cmd.Parameters.Add(new SqlParameter("@LinkCifra", SqlDbType.VarChar)).Value = musica.LinkCifra;
                    cmd.Parameters.Add(new SqlParameter("@TomOriginal", SqlDbType.Int)).Value = musica.TomOriginal;
                    cmd.Parameters.Add(new SqlParameter("@TemVs", SqlDbType.Int)).Value = musica.TemVs;
                    cmd.Parameters.Add(new SqlParameter("@Observacao", SqlDbType.VarChar)).Value = musica.Observacao;

                    cmd.ExecuteNonQuery();
                }
            }
            return ListarPorId(id);
        }
    }
}
