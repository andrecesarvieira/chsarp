using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos.Interfaces
{
    public interface IAdicionarProduto
    {
        Task ExecutarAsync(Produto produto);
    }
}