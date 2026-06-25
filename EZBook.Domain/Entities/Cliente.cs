using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Dni {  get; set; }
        public string Telefono { get; set; }
    }
}
