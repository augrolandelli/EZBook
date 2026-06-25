using EZBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.Entities
{
    public class Reserva
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Guid ServicioId { get; set; }
        public Servicio Servicio { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public EstadoReserva Estado { get; set; }
    }
}
