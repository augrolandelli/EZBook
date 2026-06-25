using EZBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string PasswordHashed { get; set; }
        public Rol Rol { get; set; }
    }
}
