using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
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
        public async Task<Usuario?> GetUsuarioById(Guid id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<Usuario?> GetUsuarioByEmail(string email)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x=>x.Email == email);
        }
    }
}
