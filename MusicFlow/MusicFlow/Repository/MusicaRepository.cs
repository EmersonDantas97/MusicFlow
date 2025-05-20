using MusicFlow.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicFlow.Repository
{
    internal class MusicaRepository
    {
        private readonly string _conexao;

        public MusicaRepository()
        {
            _conexao = ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString;
        }
        public List<Musica> ListarTodas()
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
                        integrante.Nome = dr["Nome"] as string;
                        integrante.DataCadastro = (DateTime)dr["DataCadastro"];
                        integrante.Status = (Status)Convert.ToInt32(dr["Status"]);
                        integrante.VozPrincipal = (int)dr["VozPrincipal"];
                        integrante.Bpm = (int)dr["Bpm"];
                        integrante.Versao = dr["Versao"] as string;
                        integrante.Compasso = dr["Compasso"] as string;
                        integrante.Tom = dr["Tom"] as string;
                        integrante.LinkVideo = dr["LinkVideo"] as string;
                        integrante.LinkCifra = dr["LinkCifra"] as string;
                        integrante.Observacao = dr["Observacao"] as string;
                        integrante.TomOriginal = (TomOriginal) dr["LinkCifra"];
                        integrante.TemVs = (TemVs) dr["TemVs"];

                        listaDeMusicas.Add(integrante);
                    }
                }
            }

            return listaDeMusicas;
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
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        musica = new Musica();

                        musica.Id = (int)dr["Id"];
                        musica.Nome = dr["Nome"] as string;
                        musica.DataCadastro = (DateTime)dr["DataCadastro"];
                        musica.Status = (Status)Convert.ToInt32(dr["Status"]);
                        musica.VozPrincipal = (int)dr["VozPrincipal"];
                        musica.Bpm = (int)dr["Bpm"];
                        musica.Versao = dr["Versao"] as string;
                        musica.Compasso = dr["Compasso"] as string;
                        musica.Tom = dr["Tom"] as string;
                        musica.LinkVideo = dr["LinkVideo"] as string;
                        musica.LinkCifra = dr["LinkCifra"] as string;
                        musica.Observacao = dr["Observacao"] as string;
                        musica.TomOriginal = (TomOriginal)dr["LinkCifra"];
                        musica.TemVs = (TemVs)dr["TemVs"];
                    }
                }
            }

            return musica;
        }
    }
}
