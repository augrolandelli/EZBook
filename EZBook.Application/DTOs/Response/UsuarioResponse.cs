using EZBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Application.DTOs.Response
{
    public class UsuarioResponse
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
