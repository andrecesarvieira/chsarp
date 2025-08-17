using SharpPonto25.Entities;

namespace SharpPonto25.Interfaces
{
    public interface IRegistroRepository
    {
        Task<List<Registro>> ObterRegistrosAsync();

        Task<Registro?> ObterPorId(int Id);

        Task<Registro?> ObterPorData(DateOnly data);

        Task<bool> DataExisteAsync(DateOnly data);

        Task InserirRegistroAsync(Registro registro);

        Task AtualizarRegistroAsync(Registro registro);

        Task ExcluirRegistroAsync(int Id);

        Task SalvarMudancasRegistroAsync();
    }
}
