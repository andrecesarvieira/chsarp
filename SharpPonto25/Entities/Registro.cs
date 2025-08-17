namespace SharpPonto25.Entities
{
    public class Registro
    {
        public int Id { get; set; }
        public DateOnly Data { get; set; }
        public TimeOnly Entrada { get; set; }
        public TimeOnly Almoco { get; set; }
        public TimeOnly Retorno { get; set; }
        public TimeOnly Saida { get; set; }
        public TimeOnly Manha { get; set; }
        public TimeOnly Tarde { get; set; }
        public TimeOnly TotalDia { get; set; }
    }
}
