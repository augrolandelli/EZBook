using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IReservaRepository : IBaseRepository<Reserva>
    {
        Task<Reserva?> GetById(Guid id);
    }
}
