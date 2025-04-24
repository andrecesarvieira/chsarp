using System.Globalization;
using System.Text;
using SharpPonto25.Entities;
using SharpPonto25.Interfaces;

namespace SharpPonto25.Services
{
    public class ExportarService : IExportarService
    {
        public async Task<(bool, string)> ExportarArquivoAsync(List<Registro> registros)
        {
            if (registros is null || registros.Count == 0)
                return (false, "");

            // Nome do arquivo: Timesheet_YYYYMM.csv (ano e mês corrente)  
            string nomeArquivo = $"Timesheet_{DateTime.Now:yyyyMM}.csv";
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            try
            {
                using var streamWriter = new StreamWriter(caminhoArquivo, false, Encoding.UTF8);

                foreach (var registro in registros.OrderBy(r => r.Data))
                {
                    // Formata a data para o padrão dd/MMM/yy em pt-BR  
                    string dataFormatada = registro.Data.ToString("dd/MMM/yy", new CultureInfo("pt-BR"))
                        .Replace("jan", "Jan").Replace("fev", "Fev")
                        .Replace("mar", "Mar").Replace("abr", "Abr")
                        .Replace("mai", "Mai").Replace("jun", "Jun")
                        .Replace("jul", "Jul").Replace("ago", "Ago")
                        .Replace("set", "Set").Replace("out", "Out")
                        .Replace("nov", "Nov").Replace("dez", "Dez")
                        .Replace(".", "");

                    // Monta as duas linhas conforme o padrão informado  
                    string linhaTarde = $"{dataFormatada}#|#APROVADO#|#{registro.Retorno}#|#{registro.Saida}#|#{registro.Tarde}" +
                                        "#|#00:00#|#0000#|#0000-0000#|#SIM#|#0000#|#ANALISE DE SISTEMAS#|#";

                    string linhaManha = $"{dataFormatada}#|#APROVADO#|#{registro.Entrada}#|#{registro.Almoco}#|#{registro.Manha}" +
                                        "#|#00:00#|#0000#|#0000-0000#|#SIM#|#0000#|#ANALISE DE SISTEMAS#|#";

                    // Escreve cada período em uma linha do arquivo  
                    await streamWriter.WriteLineAsync(linhaTarde);
                    await streamWriter.WriteLineAsync(linhaManha);
                }

                return (true, caminhoArquivo);
            }
            catch (Exception ex)
            {
                return (false, "");
            }
        }
    }
}
