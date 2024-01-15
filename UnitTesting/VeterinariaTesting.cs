using Microsoft.AspNetCore.Mvc;
using Proyecto_PruebasUnitarias.Controllers;
using Proyecto_PruebasUnitarias.Models;
using Proyecto_PruebasUnitarias.Services;

namespace UnitTesting
{
    public class VeterinariaTesting
    {
        private readonly VeterinariaController _controller;
        private readonly IVeterinariaService _service;

        public VeterinariaTesting()
        {
            _service = new Veterinaria_Service();
            _controller = new VeterinariaController(_service);
        }

        [Fact]
        public void Get_Ok()
        {
            var result = _controller.Get();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_Quantity()
        {
            var result = (OkObjectResult)_controller.Get();
            var veterinarias = Assert.IsType<List<Veterinaria>>(result.Value);

            Assert.True(veterinarias.Count > 0);
        }

        [Fact]
        public void GetById_Ok()
        {
            int id = 1;
            var result = _controller.GetById(id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_Exists()
        {
            int id = 1;
            var result = (OkObjectResult)_controller.GetById(id);

            var veterinaria = Assert.IsType<Veterinaria>(result?.Value);
            Assert.True(veterinaria != null);
            Assert.Equal(veterinaria?.Id, id);
        }

        [Fact]
        public void GetById_NotFound()
        {
            int id = 11;
            var result = _controller.GetById(id);
            var veterinaria = Assert.IsType<NotFoundResult>(result);
        }
    }
}