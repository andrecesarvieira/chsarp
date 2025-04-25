using SharpPonto25.Entities;

namespace SharpPonto25.Interfaces
{
    /// <summary>
    /// Interface do serviço de exportação para o arquivo csv
    /// </summary>
    public interface IExportarService
    {
        /// <summary>
        /// Tarefa para exportar o arquivo: retorna resultado da exportação e o caminho completo do arquivo
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        Task<(bool, string)> ExportarArquivoAsync(List<Registro> registro);
    }
}
