using SharpPonto25.Entities;

namespace SharpPonto25.Interfaces
{
    public interface IRegistroService
    {
        Task<List<Registro>> ObterTodosRegistrosAsync();
        Task<Registro?> ObterRegistroPorIdAsync(int id);
        Task<Registro?> ObterRegistroDoDiaAsync(DateOnly? data = null);
        Task<bool> RegistrarPontoAsync();
        Task<bool> InserirPontoAsync(Registro registro);
        Task<bool> ExcluirRegistroAsync(int id);
    }
}
