using SharpPonto25.Entities;

namespace SharpPonto25.Services
{
    public class CalcularHorasService
    {
        public static Registro CalcularHorasRegistro(Registro registro)
        {
            if (registro.Entrada != TimeOnly.FromDateTime(DateTime.MinValue) &&
                registro.Almoco != TimeOnly.FromDateTime(DateTime.MinValue))
            {
                registro.Entrada = new TimeOnly(registro.Entrada.Hour, registro.Entrada.Minute, 0);
                registro.Almoco = new TimeOnly(registro.Almoco.Hour, registro.Almoco.Minute, 0);

                TimeSpan manhaDuracao = registro.Almoco.ToTimeSpan() - registro.Entrada.ToTimeSpan();

                registro.Manha = TimeOnly.FromTimeSpan(manhaDuracao);
            }

            if (registro.Retorno != TimeOnly.FromDateTime(DateTime.MinValue) &&
                registro.Saida != TimeOnly.FromDateTime(DateTime.MinValue))
            {
                registro.Retorno = new TimeOnly(registro.Retorno.Hour, registro.Retorno.Minute, 0);
                registro.Saida = new TimeOnly(registro.Saida.Hour, registro.Saida.Minute, 0);

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
