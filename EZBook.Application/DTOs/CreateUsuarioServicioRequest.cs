using EZBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Application.DTOs
{
    public class CreateUsuarioServicioRequest
    {
        public Guid UsuarioId { get; set; }
        public Guid ServicioId { get; set; }
    }
}
