using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Domain.Entities
{
    public class Bot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Instrucciones { get; set; }
    }
}
