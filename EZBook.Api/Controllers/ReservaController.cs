using EZBook.Application.DTOs;
using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EZBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaRepository _resRepo;
        private readonly IUnitOfWork _uow;
        public ReservaController(IReservaRepository resRepo, IUnitOfWork uow)
        {
            _resRepo = resRepo;
            _uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Reserva>> Get()
        {
            return await _resRepo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Reserva?> Get(Guid id)
        {
            return await _resRepo.GetById(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateReservaRequest reserva)
        {
            Reserva res = new Reserva
            {
                UsuarioId = reserva.UsuarioId,
                ServicioId = reserva.ServicioId,
                ClienteId = reserva.ClienteId,
                FechaHoraInicio = reserva.FechaHoraInicio,
                FechaHoraFin = reserva.FechaHoraFin,
                Estado = 0
            };

            await _resRepo.AddAsync(res);
            await _uow.SaveChangesAsync();
            return Ok();
        }
    }
}
