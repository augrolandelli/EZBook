using EZBook.Application.DTOs;
using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EZBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepo;
        private readonly IUnitOfWork _uow;
        public ClienteController(IClienteRepository clienteRepo, IUnitOfWork uow)
        {
            _clienteRepo = clienteRepo;
            _uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Cliente>> Get()
        {
            return await _clienteRepo.GetAllAsync();
        }

        [HttpGet("{telefono}")]
        public async Task<Cliente?> Get(string telefono)
        {
            return await _clienteRepo.GetClientByNumber(telefono);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClienteRequest cliente)
        {
            Cliente client = new Cliente
            {
                NombreCompleto = cliente.NombreCompleto,
                Dni = cliente.Dni,
                Telefono = cliente.Telefono
            };

            await _clienteRepo.AddAsync(client);
            await _uow.SaveChangesAsync();
            return Ok();
        }
    }
}
