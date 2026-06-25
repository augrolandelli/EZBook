using EZBook.Application.DTOs;
using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EZBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _userRepo;
        private readonly IUnitOfWork _uow;
        public UsuarioController(IUsuarioRepository userRepo, IUnitOfWork uow)
        {
            _userRepo = userRepo;
            _uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Usuario>> Get()
        {
            return await _userRepo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Usuario?> Get(Guid id)
        {
            return await _userRepo.GetUsuarioById(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUsuarioRequest usuario)
        {
            Usuario user = new Usuario{ 
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Telefono = usuario.Telefono,
                PasswordHashed = usuario.Password,
                Rol = usuario.Rol
            };

            await _userRepo.AddAsync(user);
            await _uow.SaveChangesAsync();
            return Ok();
        }
    }
}
