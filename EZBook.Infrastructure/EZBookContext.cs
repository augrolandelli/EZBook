using EZBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZBook.Infrastructure
{
    public class EZBookContext : DbContext
    {
        public EZBookContext(DbContextOptions<EZBookContext> options) : base(options)
        {

        }
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<DiaHorario> DiaHorarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<UsuarioServicio> UsuarioServicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
