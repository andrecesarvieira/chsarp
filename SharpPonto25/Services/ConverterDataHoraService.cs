using SharpPonto25.Entities;

namespace SharpPonto25.Services
{
    public class ConverterDataHoraService
    {
        public Registro ConverterDataHora(string[] dados)
        {
            DateOnly data = DateOnly.TryParse(dados[0], out DateOnly temp) ? temp : DateOnly.MinValue;
            TimeOnly entrada = TimeOnly.TryParse(dados[1], out TimeOnly temp1) ? temp1 : TimeOnly.MinValue;
            TimeOnly almoco = TimeOnly.TryParse(dados[2], out TimeOnly temp2) ? temp2 : TimeOnly.MinValue;
            TimeOnly retorno = TimeOnly.TryParse(dados[3], out TimeOnly temp3) ? temp3 : TimeOnly.MinValue;
            TimeOnly saida = TimeOnly.TryParse(dados[4], out TimeOnly temp4) ? temp4 : TimeOnly.MinValue;

            var novoRegistro = new Registro
            {
                Data = data,
                Entrada = entrada,
                Almoco = almoco,
                Retorno = retorno,
                Saida = saida,
                Manha = TimeOnly.FromDateTime(DateTime.MinValue),
                Tarde = TimeOnly.FromDateTime(DateTime.MinValue),
                TotalDia = TimeOnly.FromDateTime(DateTime.MinValue)
            };

            return novoRegistro;
        }
    }
}
