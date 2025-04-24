using Microsoft.EntityFrameworkCore;
using SharpPonto25.Data;
using SharpPonto25.Entities;
using SharpPonto25.Interfaces;

namespace SharpPonto25.Repositories
{
    // Classe para definir tarefas referente as persistência de dados
    public class RegistroRepository : IRegistroRepository
    {
        private readonly AppDbContext _context;

        public RegistroRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<bool> DataExisteAsync(DateOnly data)
        {
            return await _context.Registros.AnyAsync(x => x.Data == data);
        }
        
        public async Task InserirRegistroAsync(Registro registro)
        {
            await _context.Registros.AddAsync(registro);
        }

        public Task AtualizarRegistroAsync(Registro registro)
        {
            _context.Registros.Update(registro);
            return Task.CompletedTask;
        }

        public async Task ExcluirRegistroAsync(int id)
        {
            var registro = await ObterPorId(id);
            if (registro is not null)
            {
                _context.Registros.Remove(registro);
            }
        }

        public async Task<List<Registro>> ObterRegistrosAsync()
        {
            return await _context.Registros.OrderByDescending(x => x.Data).ToListAsync();
        }

        public async Task<Registro?> ObterPorData(DateOnly data)
        {
            return await _context.Registros.FirstOrDefaultAsync(x => x.Data == data);
        }

        public async Task<Registro?> ObterPorId(int id)
        {
            return await _context.Registros.FindAsync(id);
        }

        public async Task SalvarMudancasRegistroAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
