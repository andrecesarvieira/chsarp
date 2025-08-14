using System.ComponentModel.DataAnnotations;

namespace SGE.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        [StringLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantidade deve ser maior ou igual a 0.")]
        public int Quantidade { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Preço deve ser maior ou igual a 0.")]
        public decimal Preco { get; set; }
    }
}