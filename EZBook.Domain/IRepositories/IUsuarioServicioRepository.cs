using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IUsuarioServicioRepository : IBaseRepository<UsuarioServicio>
    {
        Task<IEnumerable<Servicio>> GetServicesByUserId(Guid id);
        Task<IEnumerable<Usuario>> GetServicioUsuarios(Guid id);
    }
}
