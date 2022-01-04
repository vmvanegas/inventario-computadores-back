using Microsoft.EntityFrameworkCore;
using Mispollos.Domain.Entities;
using System;

namespace Mispollos.Persistence
{
    public class MisPollosContext : DbContext
    {
        private const string _connectionString = @"Server=.;Database=mispollos;Trusted_Connection=True;";

        public MisPollosContext()
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoProducto> PedidoProducto { get; set; }
        public DbSet<Laptop> Laptop { get; set; }
        public DbSet<BaseDeMadera> BasesDeMadera { get; set; }
        public DbSet<CableVGA> CableVGA { get; set; }
        public DbSet<Cargador> Cargador { get; set; }
        public DbSet<Diadema> Diadema { get; set; }
        public DbSet<Monitor> Monitor { get; set; }
        public DbSet<Mouse> Mouse { get; set; }
        public DbSet<Teclado> Teclado { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ModuleSeed

            modelBuilder.Entity<Rol>().HasData(
              new Rol
              {
                  Id = Guid.NewGuid(),
                  Nombre = "Admin"
              },
              new Rol
              {
                  Id = Guid.NewGuid(),
                  Nombre = "Usuario"
              }
            );

            #endregion ModuleSeed

            modelBuilder.Entity<PedidoProducto>().HasKey(x => new { x.IdPedido, x.IdProducto });
        }
    }
}