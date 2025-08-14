using SGE.CasosDeUso.InterfacePlugins;
using SGE.CasosDeUso.Inventarios.Interfaces;
using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios
{
    public class EditarItem : IEditarItem
    {
        private readonly IInventarioRepositorio item;

        public EditarItem(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task ExecutarAsync(Inventario item)
        {
            await this.item.AtualizarItemInventarioAsync(item);
        }
    }
}
