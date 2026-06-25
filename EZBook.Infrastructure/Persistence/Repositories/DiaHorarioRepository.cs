using EZBook.Domain.Entities;
using EZBook.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure.Persistence.Repositories
{

    public class DiaHorarioRepository : BaseRepository<DiaHorario>, IDiaHorarioRepository
    {
        private readonly EZBookContext _context;

        public DiaHorarioRepository(EZBookContext context) : base(context)
        {
            _context = context;
        }
    }
}
