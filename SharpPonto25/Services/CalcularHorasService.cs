using SharpPonto25.Entities;

namespace SharpPonto25.Services
{
    public class CalcularHorasService
    {
        public Registro CalcularHorasRegistro(Registro registro)
        {
            if (registro.Entrada != TimeOnly.FromDateTime(DateTime.MinValue) &&
                registro.Almoco != TimeOnly.FromDateTime(DateTime.MinValue))
            {
                TimeSpan manhaDuracao = registro.Almoco.ToTimeSpan() - registro.Entrada.ToTimeSpan();
                registro.Manha = TimeOnly.FromTimeSpan(manhaDuracao);
            }

            if (registro.Retorno != TimeOnly.FromDateTime(DateTime.MinValue) &&
                registro.Saida != TimeOnly.FromDateTime(DateTime.MinValue))
            {
                TimeSpan tardeDuracao = registro.Saida.ToTimeSpan() - registro.Retorno.ToTimeSpan();
                registro.Tarde = TimeOnly.FromTimeSpan(tardeDuracao);
            }

            registro.TotalDia = TimeOnly.FromTimeSpan(
                (registro.Manha != TimeOnly.FromDateTime(DateTime.MinValue) ? registro.Manha.ToTimeSpan() : TimeSpan.Zero) +
                (registro.Tarde != TimeOnly.FromDateTime(DateTime.MinValue) ? registro.Tarde.ToTimeSpan() : TimeSpan.Zero)
            );

            return registro;
        }
    }
}
