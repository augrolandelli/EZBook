using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<Usuario?> GetUsuarioById(Guid id);
    }
}
