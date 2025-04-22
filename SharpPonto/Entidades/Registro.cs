namespace SharpPonto.Entidades
{
    public class Registro
    {
        public DateOnly Data { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public TimeOnly Entrada { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public TimeOnly Almoco { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public TimeOnly Retorno { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public TimeOnly Saida { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public TimeOnly Manha { get; set; }
        public TimeOnly Tarde { get; set; }
        public TimeOnly TotalDia { get; set; }
    }
}
