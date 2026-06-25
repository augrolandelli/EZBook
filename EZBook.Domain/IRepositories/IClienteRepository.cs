using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<Cliente?> GetClientById(Guid id);
        Task<Cliente?> GetClientByNumber(string telefono);
    }
}
