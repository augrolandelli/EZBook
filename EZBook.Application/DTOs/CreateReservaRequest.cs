using EZBook.Domain.Entities;
using EZBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Application.DTOs
{
    public class CreateReservaRequest
    {
        public Guid UsuarioId { get; set; }
        public Guid ServicioId { get; set; }
        public Guid ClienteId { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public EstadoReserva Estado { get; set; }
    }
}
