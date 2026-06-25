using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
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
    }
}
