using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence.Repositories
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        private readonly EZBookContext _context;

        public ReservaRepository(EZBookContext context)  : base (context)
        { 
            _context = context;
        }

        public async Task<Reserva?> GetById(Guid id)
        {
            return await _context.Reservas.FirstOrDefaultAsync(x=>x.Id == id);
        }
    }
}
