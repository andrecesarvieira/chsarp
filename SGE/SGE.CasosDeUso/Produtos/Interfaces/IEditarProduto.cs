using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos.Interfaces
{
    public interface IEditarProduto
    {
        Task ExecutarAsync(Produto produto);
    }
}