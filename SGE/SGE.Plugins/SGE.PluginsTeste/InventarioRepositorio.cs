using SGE.CasosDeUso.InterfacePlugins;
using SGE.Entidades;

namespace SGE.PluginsTeste
{
    public class InventarioRepositorio : IInventarioRepositorio
    {
        public List<Inventario> _inventarios = new List<Inventario>
        {
            new() { Id = 1, Nome = "Item A", Quantidade = 10, Preco = 100.00m },
            new() { Id = 2, Nome = "Item B", Quantidade = 5, Preco = 50.00m },
            new() { Id = 3, Nome = "Item C", Quantidade = 20, Preco = 20.00m }
        };

        public Task AdicionarItemInventarioAsync(Inventario item)
        {
            if (_inventarios.Any(i=> i.Nome.Equals(item.Nome, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }
            else
            {
                int MaxId = 0;
                if (_inventarios.Count > 0)
                {
                    MaxId = _inventarios.Max(i => i.Id);
                }
                item.Id = MaxId + 1;
                _inventarios.Add(item);
                return Task.CompletedTask;
            }
        }

        public Task AtualizarItemInventarioAsync(Inventario item)
        {
            if (_inventarios.Any(i => i.Id != item.Id && i.Nome.Equals(item.Nome, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var itemExistente = _inventarios.FirstOrDefault(i => i.Id == item.Id);
            if (itemExistente != null)
            {
                itemExistente.Nome = item.Nome;
                itemExistente.Quantidade = item.Quantidade;
                itemExistente.Preco = item.Preco;
            }
            return Task.CompletedTask;
        }

        public Task ExcluirItemInventarioAsync(int id)
        {
            var itemExistente = _inventarios.FirstOrDefault(i => i.Id == id);
            if (itemExistente != null)
            {
                _inventarios.Remove(itemExistente);
            }
            return Task.CompletedTask;
        }

        public async Task<Inventario> BuscarItemPorIdAsync(int id)
        {
            return await Task.FromResult(_inventarios.First(x => x.Id == id));
        }

        public async Task<IEnumerable<Inventario>> BuscarItemPorNomeAsync(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return await Task.FromResult<IEnumerable<Inventario>>(_inventarios);
            }
            else
            {
                var resultado = _inventarios.Where(i => i.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));
                return await Task.FromResult<IEnumerable<Inventario>>(resultado);
            }
        }
    }
}
