using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence.Repositories
{
    public class BotRepository : BaseRepository<Bot>, IBotRepository
    {
        private readonly EZBookContext _context;

        public BotRepository(EZBookContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Bot?> GetBotById(Guid id)
        {
            return await _context.Bots.FirstOrDefaultAsync(x=>x.Id == id);
        }
    }
}
