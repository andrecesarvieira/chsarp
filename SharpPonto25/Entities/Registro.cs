namespace SharpPonto25.Entities
{
    /// <summary>
    /// Representa um registro de ponto com entrada, saída e cálculos de horas trabalhadas.
    /// </summary>
    public class Registro
    {
        /// <summary>
        /// Identificador único do registro.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Data do registro de ponto.
        /// </summary>
        public DateOnly Data { get; set; }

        /// <summary>
        /// Horário de entrada do funcionário.
        /// </summary>
        public TimeOnly Entrada { get; set; }

        /// <summary>
        /// Horário de saída para almoço.
        /// </summary>
        public TimeOnly Almoco { get; set; }

        /// <summary>
        /// Horário de retorno do almoço.
        /// </summary>
        public TimeOnly Retorno { get; set; }

        /// <summary>
        /// Horário de saída do expediente.
        /// </summary>
        public TimeOnly Saida { get; set; }

        /// <summary>
        /// Total de horas trabalhadas no período da manhã.
        /// </summary>
        public TimeOnly Manha { get; set; }

        /// <summary>
        /// Total de horas trabalhadas no período da tarde.
        /// </summary>
        public TimeOnly Tarde { get; set; }

        /// <summary>
        /// Total de horas trabalhadas no dia.
        /// </summary>
        public TimeOnly TotalDia { get; set; }
    }
}
