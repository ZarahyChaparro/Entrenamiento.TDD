using Proyecto_PruebasUnitarias.Models;

namespace Proyecto_PruebasUnitarias.Services
{
    public class Veterinaria_Service : IVeterinariaService
    {

        private List<Veterinaria> _veterinarias = new List<Veterinaria>()
        {
            new Veterinaria() { Id = 1, Name = "VetPet", Description = "Ofrecemos servicios de peluqueria y consultas"},
            new Veterinaria() { Id = 2, Name = "PetShop", Description = "Ofrecemos servicios de peluqueria, consultas medicas, entre otras servicios"}
        };

        public IEnumerable<Veterinaria> Get() => _veterinarias;
        public Veterinaria? Get(int id) => _veterinarias.FirstOrDefault(d => d.Id == id);


    }
}
