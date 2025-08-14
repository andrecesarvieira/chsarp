using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Inventarios.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios
{
    public class AdicionarItem : IAdicionarItem
    {
        private readonly IInventarioRepositorio item;

        public AdicionarItem(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task ExecutarAsync(Inventario item)
        {
            await this.item.AdicionarItemInventarioAsync(item);
        }
    }
}
