using SGE.Entidades;

namespace SGE.CasosDeUso.Inventarios.Interfaces
{
    public interface IBuscarItemPorNome
    {
        Task<IEnumerable<Inventario>> ExecutarAsync(string nome = "");
    }
}