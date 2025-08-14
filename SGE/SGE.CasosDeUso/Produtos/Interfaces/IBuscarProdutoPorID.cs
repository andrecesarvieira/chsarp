using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos.Interfaces
{
    public interface IBuscarProdutoPorID
    {
        Task<Produto> ExecutarAsync(int id);
    }
}