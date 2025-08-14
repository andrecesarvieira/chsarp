using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos.Interfaces
{
    public interface IBuscarProdutoPorNome
    {
        Task<IEnumerable<Produto>> ExecutarAsync(string nome = "");
    }
}