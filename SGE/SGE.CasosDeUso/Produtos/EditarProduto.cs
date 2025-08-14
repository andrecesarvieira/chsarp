using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Produtos.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos
{
    public class EditarProduto : IEditarProduto
    {
        private readonly IProdutoRepositorio produto;

        public EditarProduto(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task ExecutarAsync(Produto produto)
        {
            await this.produto.AtualizarProdutoAsync(produto);
        }
    }
}
