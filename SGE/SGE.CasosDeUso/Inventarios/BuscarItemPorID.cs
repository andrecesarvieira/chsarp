using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Inventarios.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios
{
    public class BuscarItemPorID : IBuscarItemPorID
    {
        private readonly IInventarioRepositorio item;

        public BuscarItemPorID(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task<Inventario> ExecutarAsync(int id)
        {
            return await item.BuscarItemPorIdAsync(id);
        }
    }
}
