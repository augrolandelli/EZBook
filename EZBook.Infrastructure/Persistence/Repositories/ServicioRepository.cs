using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence.Repositories
{
    public class ServicioRepository : BaseRepository<Servicio>, IServicioRepository
    {
        private readonly EZBookContext _context;

        public ServicioRepository(EZBookContext context) : base(context)
        {
            _context = context;
        }
    }
}
