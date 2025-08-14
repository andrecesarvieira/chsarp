using SGE.CasosDeUso.InterfacePlugins;
using SGE.Entidades;

namespace SGE.PluginsTeste
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public List<Produto> _produtos = new List<Produto>
        {
            new() { Id = 1, Nome = "Produto A", Quantidade = 10, Preco = 100.00m },
            new() { Id = 2, Nome = "Produto B", Quantidade = 5, Preco = 50.00m },
            new() { Id = 3, Nome = "Produto C", Quantidade = 20, Preco = 20.00m }
        };

        public Task AdicionarProdutoAsync(Produto produto)
        {
            if (_produtos.Any(i=> i.Nome.Equals(produto.Nome, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }
            else
            {
                int MaxId = 0;
                if (_produtos.Count > 0)
                {
                    MaxId = _produtos.Max(i => i.Id);
                }
                produto.Id = MaxId + 1;
                _produtos.Add(produto);
                return Task.CompletedTask;
            }
        }

        public Task AtualizarProdutoAsync(Produto produto)
        {
            if (_produtos.Any(i => i.Id != produto.Id && i.Nome.Equals(produto.Nome, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var produtoExistente = _produtos.FirstOrDefault(i => i.Id == produto.Id);
            if (produtoExistente != null)
            {
                produtoExistente.Nome = produto.Nome;
                produtoExistente.Quantidade = produto.Quantidade;
                produtoExistente.Preco = produto.Preco;
            }
            return Task.CompletedTask;
        }

        public Task ExcluirProdutoAsync(int id)
        {
            var produtoExistente = _produtos.FirstOrDefault(i => i.Id == id);
            if (produtoExistente != null)
            {
                _produtos.Remove(produtoExistente);
            }
            return Task.CompletedTask;
        }

        public async Task<Produto> BuscarProdutoPorIdAsync(int id)
        {
            return await Task.FromResult(_produtos.First(x => x.Id == id));
        }

        public async Task<IEnumerable<Produto>> BuscarProdutoPorNomeAsync(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return await Task.FromResult<IEnumerable<Produto>>(_produtos);
            }
            else
            {
                var resultado = _produtos.Where(i => i.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));
                return await Task.FromResult<IEnumerable<Produto>>(resultado);
            }
        }
    }
}
