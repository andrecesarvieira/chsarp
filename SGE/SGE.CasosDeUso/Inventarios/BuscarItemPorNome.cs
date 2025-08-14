using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Inventarios.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios
{
    public class BuscarItemPorNome : IBuscarItemPorNome
    {
        private readonly IInventarioRepositorio item;

        public BuscarItemPorNome(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task<IEnumerable<Inventario>> ExecutarAsync(string nome = "")
        {
            return await item.BuscarItemPorNomeAsync(nome);
        }
    }
}
