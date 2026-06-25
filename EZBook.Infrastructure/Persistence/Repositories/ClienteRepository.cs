using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly EZBookContext _context;

        public ClienteRepository(EZBookContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Cliente?> GetClientById(Guid id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Cliente?> GetClientByNumber(string telefono)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Telefono == telefono);
        }
    }
}
