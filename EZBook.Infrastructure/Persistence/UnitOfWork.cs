using EZBook.Domain.IRepositories;
using EZBook.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EZBookContext _context;
        
        public UnitOfWork(EZBookContext context)
        {
            _context = context;
        }

        private IBotRepository? _bots;
        public IBotRepository Bots => _bots ??= new BotRepository(_context);

        private IClienteRepository? _clientes;
        public IClienteRepository Clientes => _clientes ??= new ClienteRepository(_context);

        private IUsuarioRepository? _usuarios;
        public IUsuarioRepository Usuarios => _usuarios ??= new UsuarioRepository(_context);

        private IServicioRepository? _servicios;
        public IServicioRepository Servicios => _servicios ??= new ServicioRepository(_context);

        private IUsuarioServicioRepository? _usuarioServicios;
        public IUsuarioServicioRepository UsuarioServicios => _usuarioServicios ??= new UsuarioServicioRepository(_context);

        private IReservaRepository? _reservas;
        public IReservaRepository Reservas => _reservas ??= new ReservaRepository(_context);

        private IDiaHorarioRepository? _diaHorarios;
        public IDiaHorarioRepository DiaHorarios => _diaHorarios ??= new DiaHorarioRepository(_context);




        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
