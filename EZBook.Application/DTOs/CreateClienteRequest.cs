using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Application.DTOs
{
    public class CreateClienteRequest
    {
        public string NombreCompleto { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
    }
}
