using Microsoft.EntityFrameworkCore;
using SharpPonto25.Data;
using SharpPonto25.Entities;
using SharpPonto25.Interfaces;

namespace SharpPonto25.Repositories
{
    /// <summary>
    /// Módulo para definir tarefas referente as persistência de dados
    /// </summary>
    public class RegistroRepository : IRegistroRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="context"></param>
        public RegistroRepository(AppDbContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Busca pela chave data no banco de dados inteiro
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<bool> DataExisteAsync(DateOnly data)
        {
            return await _context.Registros.AnyAsync(x => x.Data == data);
        }
        
        /// <summary>
        /// Inserir novo registro
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public async Task InserirRegistroAsync(Registro registro)
        {
            await _context.Registros.AddAsync(registro);
        }

        /// <summary>
        /// Atualizar registro existente
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public Task AtualizarRegistroAsync(Registro registro)
        {
            _context.Registros.Update(registro);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Excluir registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task ExcluirRegistroAsync(int id)
        {
            var registro = await ObterPorId(id);
            if (registro is not null)
            {
                _context.Registros.Remove(registro);
            }
        }

        /// <summary>
        /// Obtem todos os registros
        /// </summary>
        /// <returns></returns>
        public async Task<List<Registro>> ObterRegistrosAsync()
        {
            return await _context.Registros.OrderByDescending(x => x.Data).ToListAsync();
        }

        /// <summary>
        /// Busca pela chave data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<Registro?> ObterPorData(DateOnly data)
        {
            return await _context.Registros.FirstOrDefaultAsync(x => x.Data == data);
        }

        /// <summary>
        /// Busca pela chave id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Registro?> ObterPorId(int id)
        {
            return await _context.Registros.FindAsync(id);
        }

        /// <summary>
        /// Aplica as mudanças no banco de dados
        /// </summary>
        /// <returns></returns>
        public async Task SalvarMudancasRegistroAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
