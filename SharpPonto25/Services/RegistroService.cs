using SharpPonto25.Entities;
using SharpPonto25.Interfaces;

namespace SharpPonto25.Services
{
    public class RegistroService : IRegistroService
    {
        private readonly IRegistroRepository _repository;
        private readonly TimeOnly _tempoVazio = TimeOnly.FromDateTime(DateTime.MinValue);
        
        public RegistroService(IRegistroRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Registro>> ObterTodosRegistrosAsync()
        {
            return await _repository.ObterRegistrosAsync();
        }
        
        public async Task<Registro?> ObterRegistroPorIdAsync(int id)
        {
            return await _repository.ObterPorId(id);
        }

        public async Task<Registro?> ObterRegistroDoDiaAsync(DateOnly? data = null)
        {
            var dataConsulta = data ?? DateOnly.FromDateTime(DateTime.Now);
            return await _repository.ObterPorData(dataConsulta);
        }

        public async Task<bool> RegistrarPontoAsync()
        {
            var dataHoje = DateOnly.FromDateTime(DateTime.Now);
            var horaAtual = TimeOnly.FromDateTime(DateTime.Now);

            // Verifica se já existe registro para hoje
            bool registroExiste = await _repository.DataExisteAsync(dataHoje);

            if (!registroExiste)
            {
                var novoRegistro = new Registro
                {
                    Data = dataHoje,
                    Entrada = horaAtual,
                    Almoco = _tempoVazio,
                    Retorno = _tempoVazio,
                    Saida = _tempoVazio,
                    Manha = _tempoVazio,
                    Tarde = _tempoVazio,
                    TotalDia = _tempoVazio
                };

                await _repository.InserirRegistroAsync(novoRegistro);
            }
            else
            {
                // Atualizar registro existente
                var registro = await _repository.ObterPorData(dataHoje);

                if (registro is null)
                {
                    return false;
                }

                // Preenche o próximo campo vazio na sequência
                if (registro.Entrada == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Entrada = horaAtual;
                else if (registro.Almoco == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Almoco = horaAtual;
                else if (registro.Retorno == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Retorno = horaAtual;
                else if (registro.Saida == TimeOnly.FromDateTime(DateTime.MinValue))
                    registro.Saida = horaAtual;

                var reg = CalcularHorasService.CalcularHorasRegistro(registro);

                await _repository.AtualizarRegistroAsync(reg);
            }

            await _repository.SalvarMudancasRegistroAsync();
            return true;
        }

        public async Task<bool> InserirPontoAsync(Registro registro)
        {
            // Verifica se já existe registro com a mesma data
            bool registroExiste = await _repository.DataExisteAsync(registro.Data);

            if (!registroExiste)
            {
                var reg = CalcularHorasService.CalcularHorasRegistro(registro);

                await _repository.InserirRegistroAsync(reg);
                await _repository.SalvarMudancasRegistroAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> ExcluirRegistroAsync(int id)
        {
            await _repository.ExcluirRegistroAsync(id);
            await _repository.SalvarMudancasRegistroAsync();
            return true;
        }
    }
}
