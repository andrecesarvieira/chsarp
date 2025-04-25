using SharpPonto25.Entities;

namespace SharpPonto25.Interfaces
{
    /// <summary>
    /// Interface para gerenciar as tarefas referente a persistência de dados
    /// </summary>
    public interface IRegistroRepository
    {
        /// <summary>
        /// Tarefa para obter todos os registros
        /// </summary>
        /// <returns></returns>
        Task<List<Registro>> ObterRegistrosAsync();

        /// <summary>
        /// Tarefa para obter registro pela chave id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Registro?> ObterPorId(int Id);

        /// <summary>
        /// Tarefa para obter registro pela chave data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<Registro?> ObterPorData(DateOnly data);

        /// <summary>
        /// Tarefa para verificar se a chave data existe no banco de dados
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<bool> DataExisteAsync(DateOnly data);

        /// <summary>
        /// Tarefa para inserir registro no banco de dados
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        Task InserirRegistroAsync(Registro registro);

        /// <summary>
        /// Tarefa para atualizar registro no banco de dados
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        Task AtualizarRegistroAsync(Registro registro);

        /// <summary>
        /// Tarefa para excluir registro no banco de dados
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task ExcluirRegistroAsync(int Id);

        /// <summary>
        /// Tarefa para aplicar as mudanças no banco de dados
        /// </summary>
        /// <returns></returns>
        Task SalvarMudancasRegistroAsync();
    }
}
