using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Produtos.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos
{
    public class BuscarProdutoPorID : IBuscarProdutoPorID
    {
        private readonly IProdutoRepositorio produto;

        public BuscarProdutoPorID(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task<Produto> ExecutarAsync(int id)
        {
            return await produto.BuscarProdutoPorIdAsync(id);
        }
    }
}
