using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.Entities
{
    public class UsuarioServicio
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Guid ServicioId { get; set; }
        public Servicio Servicio { get; set; }
    }
}
