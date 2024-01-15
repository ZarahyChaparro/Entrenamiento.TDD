using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_PruebasUnitarias.Services;

namespace Proyecto_PruebasUnitarias.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VeterinariaController : ControllerBase
    {
        private readonly IVeterinariaService _veterinariaService;

        public VeterinariaController(IVeterinariaService service)
        {
            _veterinariaService = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_veterinariaService.Get());

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var veterinaria = _veterinariaService.Get(Id);
            if (veterinaria == null)
                return NotFound();

            return Ok(veterinaria);

        }
    }
}