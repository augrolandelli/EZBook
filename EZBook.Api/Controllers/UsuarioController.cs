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
        private readonly IUsuarioServicioRepository _userServiceRepo;
        private readonly IDiaHorarioRepository _userDiaHorarioRepo;
        private readonly IUnitOfWork _uow;
        public UsuarioController(IUsuarioRepository userRepo, IUsuarioServicioRepository userServiceRepo, IDiaHorarioRepository diaHorarioRepo ,IUnitOfWork uow)
        {
            _userRepo = userRepo;
            _userServiceRepo = userServiceRepo;
            _userDiaHorarioRepo = diaHorarioRepo;
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
        [HttpGet("{id}/services")]
        public async Task<IEnumerable<Servicio>> GetUserServices(Guid id)
        {
            return await _userServiceRepo.GetServicesByUserId(id);
        }

        [HttpPost("{id}/services")]
        public async Task<IActionResult> CreateUserServices([FromBody] CreateUsuarioServicioRequest userService)
        {
            UsuarioServicio userServ = new UsuarioServicio
            {
                UsuarioId = userService.UsuarioId,
                ServicioId = userService.ServicioId
            };

            await _userServiceRepo.AddAsync(userServ);
            await _uow.SaveChangesAsync();
            return Ok(userServ);
        }

        [HttpGet("{id}/horarios")]
        public async Task<IEnumerable<DiaHorario>> GetUserHorarios(Guid id)
        {
            return await _userDiaHorarioRepo.GetDiaHorariosByUserId(id);
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

        [HttpPost("{id}/horarios")]
        public async Task<IActionResult> PostUserHorarios([FromBody] CreateDiaHorarioUsuarioRequest request)
        {
            DiaHorario diaHorario = new DiaHorario { 
                UsuarioId = request.UsuarioId,
                Dia = request.Dia,
                Inicio = request.Inicio,
                Fin = request.Fin,
            };
            await _userDiaHorarioRepo.AddAsync(diaHorario);
            await _uow.SaveChangesAsync();
            return Ok(diaHorario);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            var user = await _userRepo.GetUsuarioByEmail(login.Email);
            string token = user.Id + "_" + user.Nombre + "_" + user.Rol;
            return Ok(token);
        }
    }
}