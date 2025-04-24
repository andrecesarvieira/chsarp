using SharpPonto25.Entities;

namespace SharpPonto25.Interfaces
{
    public interface IExportarService
    {
        Task<(bool,string)>ExportarArquivoAsync(List<Registro> registro);
    }
}
