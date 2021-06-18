using Microsoft.EntityFrameworkCore;
using RegistroPedidos_Blazord.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace RegistroPedidos_Blazord.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=DATA\BDPedidos.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Suplidores>().HasData(
                new Suplidores { SuplidorId = 1, Nombres = "Juan Carlos Iwasaki" }
                );

            modelBuilder.Entity<Suplidores>().HasData(
                new Suplidores { SuplidorId = 2, Nombres = "Ramiro Verdoljak" }
                );
            modelBuilder.Entity<Suplidores>().HasData(
                new Suplidores { SuplidorId = 3, Nombres = "Thomas Nahuel" }
                );

            modelBuilder.Entity<Productos>().HasData(
                new Productos { ProductoId = 1, Descripcion = "Bocina", Costo = 100, Inventario = 5 }
                );

            modelBuilder.Entity<Productos>().HasData(
                new Productos { ProductoId = 2, Descripcion = "Auriculares", Costo = 45, Inventario = 3 }
                );

            modelBuilder.Entity<Productos>().HasData(
                new Productos { ProductoId = 3, Descripcion = "Radio", Costo = 150, Inventario = 10 }
                );
        }
    }
}

