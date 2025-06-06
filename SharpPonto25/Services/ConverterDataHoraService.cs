﻿using SharpPonto25.Entities;

namespace SharpPonto25.Services
{
    /// <summary>
    /// Módulo para tratar as conversões de data e hora
    /// </summary>
    public class ConverterDataHoraService
    {
        private readonly TimeOnly _tempoVazio = TimeOnly.FromDateTime(DateTime.MinValue);

        /// <summary>
        /// Faz a conversão da data e horários em string para o tipo apropriado
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
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
                Manha = _tempoVazio,
                Tarde = _tempoVazio,
                TotalDia = _tempoVazio
            };

            return novoRegistro;
        }
    }
}
