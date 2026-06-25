using EZBook.Application.DTOs;
using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EZBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        private readonly IBotRepository _botRepo;
        private readonly IUnitOfWork _uow;
        public BotController(IBotRepository botRepo, IUnitOfWork uow)
        {
            _botRepo = botRepo;
            _uow = uow;
        }
        [HttpGet]
        public async Task<IEnumerable<Bot>> Get()
        {
            return await _botRepo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Bot?> Get(Guid id)
        {
            return await _botRepo.GetBotById(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBotRequest bot)
        {
            Bot b = new Bot
            {
                Name = bot.Name,
                Instrucciones = bot.Instrucciones
            };

            await _botRepo.AddAsync(b);
            await _uow.SaveChangesAsync();
            return Ok();
        }
    }
}
