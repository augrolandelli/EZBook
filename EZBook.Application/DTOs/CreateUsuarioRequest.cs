using EZBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Application.DTOs
{
    public class CreateUsuarioRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Rol Rol { get; set; }
    }
}
