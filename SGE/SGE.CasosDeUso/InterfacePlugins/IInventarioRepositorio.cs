using SGE.Entidades;

namespace SGE.CasosDeUso.InterfacePlugins
{
    public interface IInventarioRepositorio
    {
        Task AdicionarItemInventarioAsync(Inventario item);
        Task AtualizarItemInventarioAsync(Inventario item);
        Task ExcluirItemInventarioAsync(int id);
        Task<Inventario> BuscarItemPorIdAsync(int id);
        Task<IEnumerable<Inventario>> BuscarItemPorNomeAsync(string nome);
    }
}
