using EZBook.Application.DTOs;
using EZBook.Application.DTOs.Response;
using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EZBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly IServicioRepository _serRepo;
        private readonly IUsuarioServicioRepository _userServiceRepo;
        private readonly IUnitOfWork _uow;
        public ServicioController(IServicioRepository serRepo, IUsuarioServicioRepository userServiceRepo, IUnitOfWork uow)
        {
            _serRepo = serRepo;
            _userServiceRepo = userServiceRepo;
            _uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Servicio>> Get()
        {
            return await _serRepo.GetAllAsync();
        }

        [HttpGet("{id}/usuarios")]
        public async Task<IEnumerable<UsuarioResponse>> GetServiceUsers(Guid id)
        {
            var usuarios = await _userServiceRepo.GetServicioUsuarios(id);

            var response = usuarios.Select(u => new UsuarioResponse
            {
                Id = u.Id,
                Nombre = u.Nombre,
                Apellido = u.Apellido
            });

            return response;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateServicioRequest servicio)
        {
            Servicio ser = new Servicio
            {
                Nombre = servicio.Nombre,
                Descripcion = servicio.Descripcion,
                Precio = servicio.Precio,
                Duracion = servicio.Duracion,
                Descanso = servicio.Descanso
            };

            await _serRepo.AddAsync(ser);
            await _uow.SaveChangesAsync();
            return Ok();
        }
    }
}
