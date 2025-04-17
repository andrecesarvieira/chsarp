using System.Data.SQLite;
using SharpPonto.Entidades;
using System.Data;

namespace SharpPonto.Dados
{
    public class Database
    {
        private static readonly string anoMesCorrente = DateTime.Now.ToString("yyyyMM");
        public static readonly string path = Directory.GetCurrentDirectory() + "\\SharpPonto_" + anoMesCorrente + ".db";
        private static SQLiteConnection? conexao;

        private static SQLiteConnection Conexao()
        {
            conexao = new SQLiteConnection("Data Source=" + path);
            conexao.Open();
            return conexao;
        }

        public static void CriarBancoDeDados()
        {
            try
            {
                if (!File.Exists(path))
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o arquivo db: " + ex.Message);
            }
        }

        public static void CriarTabela()
        {
            try
            {
                using var conexao = Conexao();
                using var cmd = conexao.CreateCommand();
                cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Registros (
                            Data TEXT PRIMARY KEY,
                            Entrada TEXT,
                            Almoco TEXT,
                            Retorno TEXT,
                            Saida TEXT,
                            Manha TEXT,
                            Tarde TEXT,
                            TotalDia TEXT
                        );";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a tabela: " + ex.Message);
            }
        }

        public static DataTable LerRegistros()
        {
            DataTable dt = new();
            try
            {
                using var conexao = Conexao();
                using var cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM Registros ORDER BY Data DESC";
                SQLiteDataAdapter? da = new SQLiteDataAdapter(cmd.CommandText, Conexao());
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("LerRegistros - Erro ao ler a tabela: " + ex.Message, ex);
            }
        }

        public static DataTable LerRegistro(string data)
        {
            DataTable dt = new();
            try
            {
                using var conexao = Conexao();
                using var cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM Registros WHERE Data = @Data";
                cmd.Parameters.AddWithValue("@Data", data);
                SQLiteDataAdapter? da = new(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler a tabela pela Data: " + ex.Message, ex);
            }
        }

        public static void InserirRegistro(Registro registro, int n)
        {
            try
            {
                using var conexao = Conexao();
                using var cmd = conexao.CreateCommand();
                switch (n)
                {
                    case 1:
                        cmd.CommandText = "INSERT INTO Registros (Data, Entrada, Almoco, Retorno, Saida, Manha, Tarde, TotalDia) " +
                            "VALUES (@Data, @Entrada, @Almoco, @Retorno, @Saida, @Manha, @Tarde, @TotalDia);";
                        cmd.Parameters.AddWithValue("@Data", registro.Data.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@Entrada", registro.Entrada.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Almoco", registro.Almoco.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Retorno", registro.Retorno.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Saida", registro.Saida.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Manha", registro.Manha.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Tarde", registro.Tarde.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@TotalDia", registro.TotalDia.ToString("HH:mm"));
                        cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        cmd.CommandText = "UPDATE Registros SET Almoco = @Almoco, Manha = @Manha WHERE Data = @Data;";
                        cmd.Parameters.AddWithValue("@Data", registro.Data.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@Almoco", registro.Almoco.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Manha", registro.Manha.ToString("HH:mm"));
                        cmd.ExecuteNonQuery();
                        break;
                    case 3:
                        cmd.CommandText = "UPDATE Registros SET Retorno = @Retorno WHERE Data = @Data;";
                        cmd.Parameters.AddWithValue("@Data", registro.Data.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@Retorno", registro.Retorno.ToString("HH:mm"));
                        cmd.ExecuteNonQuery();
                        break;
                    case 4:
                        cmd.CommandText = "UPDATE Registros SET Saida = @Saida, Tarde = @Tarde, TotalDia = @TotalDia WHERE Data = @Data;";
                        cmd.Parameters.AddWithValue("@Data", registro.Data.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@Saida", registro.Saida.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Tarde", registro.Tarde.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@TotalDia", registro.TotalDia.ToString("HH:mm"));
                        cmd.ExecuteNonQuery();
                        break;
                    case 5:
                        cmd.CommandText = "INSERT INTO Registros (Data, Entrada, Almoco, Retorno, Saida, Manha, Tarde, TotalDia) " +
                            "VALUES (@Data, @Entrada, @Almoco, @Retorno, @Saida, @Manha, @Tarde, @TotalDia);";
                        cmd.Parameters.AddWithValue("@Data", registro.Data.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@Entrada", registro.Entrada.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Almoco", registro.Almoco.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Retorno", registro.Retorno.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Saida", registro.Saida.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Manha", registro.Manha.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@Tarde", registro.Tarde.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@TotalDia", registro.TotalDia.ToString("HH:mm"));
                        cmd.ExecuteNonQuery();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o registro: " + ex.Message, ex);
            }
        }

        public static void ExcluirRegistro(string data)
        {
            try
            {
                using var conexao = Conexao();
                using var cmd = conexao.CreateCommand();
                cmd.CommandText = "DELETE FROM Registros WHERE Data=@Data";
                cmd.Parameters.AddWithValue("@Data", data);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o registro: " + ex.Message, ex);
            }
        }
    }
}
