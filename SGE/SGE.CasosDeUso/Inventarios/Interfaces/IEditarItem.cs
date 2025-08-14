using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios.Interfaces
{
    public interface IEditarItem
    {
        Task ExecutarAsync(Inventario item);
    }
}