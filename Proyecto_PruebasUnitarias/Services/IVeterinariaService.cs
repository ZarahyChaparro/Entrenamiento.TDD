using Proyecto_PruebasUnitarias.Models;

namespace Proyecto_PruebasUnitarias.Services
{
    public interface IVeterinariaService
    {
        public IEnumerable<Veterinaria> Get();
        public Veterinaria? Get(int id);

    }
}
