using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.Entities
{
    public class Servicio
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public decimal Precio { get; set; }
        public int Duracion { get; set; }
        public int Descanso { get; set; }

    }
}
