using EZBook.Application.DTOs.Response;
using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Servicio>> GetServicesByUserId(Guid id)
        {
            return await _context.UsuarioServicios.Where(u=>u.UsuarioId == id).Select(s=>s.Servicio).ToListAsync();
        }

        public async Task<IEnumerable<Usuario>> GetServicioUsuarios(Guid id)
        {
            return await _context.UsuarioServicios
                .Where(x => x.ServicioId == id)
                .Select(x=>x.Usuario)
                .ToListAsync();
        }
    }
}
