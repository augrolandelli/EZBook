using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IUnitOfWork
    {
        IBotRepository Bots {  get; }
        IUsuarioRepository Usuarios { get; }
        IClienteRepository Clientes { get; }
        IReservaRepository Reservas {  get; }
        IDiaHorarioRepository DiaHorarios { get; }
        IServicioRepository Servicios { get; }
        IUsuarioServicioRepository UsuarioServicios { get; }
        Task<int> SaveChangesAsync();
    }
}
