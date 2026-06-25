using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly EZBookContext _context;

        public UsuarioRepository(EZBookContext context) : base(context)
        {
            _context = context;
        }
    }
}
