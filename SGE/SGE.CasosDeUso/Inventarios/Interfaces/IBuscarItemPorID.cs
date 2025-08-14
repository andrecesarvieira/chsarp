using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios.Interfaces
{
    public interface IBuscarItemPorID
    {
        Task<Inventario> ExecutarAsync(int id);
    }
}