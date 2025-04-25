using SharpPonto25.Entities;

namespace SharpPonto25.Interfaces
{
    /// <summary>
    /// Interface para gerenciar as tarefas referente as regras de negócio
    /// </summary>
    public interface IRegistroService
    {
        /// <summary>
        /// Tarefa para obter registros
        /// </summary>
        /// <returns></returns>
        Task<List<Registro>> ObterTodosRegistrosAsync();

        /// <summary>
        /// Tarefa para obter registro por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Registro?> ObterRegistroPorIdAsync(int id);

        /// <summary>
        /// Tarefa para obter registro pela data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<Registro?> ObterRegistroDoDiaAsync(DateOnly? data = null);

        /// <summary>
        /// Tarefa para registrar ponto
        /// </summary>
        /// <returns></returns>
        Task<bool> RegistrarPontoAsync();

        /// <summary>
        /// Tarefa para inserir ponto
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        Task<bool> InserirPontoAsync(Registro registro);

        /// <summary>
        /// Tarefa para excluir registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> ExcluirRegistroAsync(int id);
    }
}
