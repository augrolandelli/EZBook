using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence.Repositories
{
    public class UsuarioServicioRepository : BaseRepository<UsuarioServicio>, IUsuarioServicioRepository
    {
        private readonly EZBookContext _context;

        public UsuarioServicioRepository(EZBookContext context) : base(context)
        {
            _context = context;
        }
    }
}
