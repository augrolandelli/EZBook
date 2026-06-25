using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.Entities
{
    public class DiaHorario
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Dia { get; set; }
        public TimeOnly Inicio { get; set; }
        public TimeOnly Fin {  get; set; }

    }
}
