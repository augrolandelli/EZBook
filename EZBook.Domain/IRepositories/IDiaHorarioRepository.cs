using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.IRepositories
{
    public interface IDiaHorarioRepository : IBaseRepository<DiaHorario>
    {
        Task<IEnumerable<DiaHorario>> GetDiaHorariosByUserId(Guid id);
    }
}
