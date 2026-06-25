using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IBotRepository : IBaseRepository<Bot>
    {
        Task<Bot?> GetBotById(Guid id);
    }
}
