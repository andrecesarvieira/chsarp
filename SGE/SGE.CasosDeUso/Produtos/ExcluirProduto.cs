using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Produtos.Interfaces;

namespace SGE.CasosDeUso.Produtos
{
    public class ExcluirProduto : IExcluirProduto
    {
        private readonly IProdutoRepositorio produto;

        public ExcluirProduto(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task ExecutarAsync(int id)
        {
            await this.produto.ExcluirProdutoAsync(id);
        }
    }
}
