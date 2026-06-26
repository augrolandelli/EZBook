using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Application.DTOs
{
    public class CreateDiaHorarioUsuarioRequest
    {
        public Guid UsuarioId { get; set; }
        public string Dia { get; set; }
        public TimeOnly Inicio { get; set; }
        public TimeOnly Fin { get; set; }
    }
}
