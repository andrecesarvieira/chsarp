using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Produtos.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Produtos
{
    public class BuscarProdutoPorNome : IBuscarProdutoPorNome
    {
        private readonly IProdutoRepositorio produto;

        public BuscarProdutoPorNome(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task<IEnumerable<Produto>> ExecutarAsync(string nome = "")
        {
            return await produto.BuscarProdutoPorNomeAsync(nome);
        }
    }
}
