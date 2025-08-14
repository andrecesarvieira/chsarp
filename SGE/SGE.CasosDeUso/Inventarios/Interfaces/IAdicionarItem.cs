using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios.Interfaces
{
    public interface IAdicionarItem
    {
        Task ExecutarAsync(Inventario item);
    }
}