using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Produtos.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos
{
    public class AdicionarProduto : IAdicionarProduto
    {
        private readonly IProdutoRepositorio produto;

        public AdicionarProduto(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task ExecutarAsync(Produto produto)
        {
            await this.produto.AdicionarProdutoAsync(produto);
        }
    }
}
