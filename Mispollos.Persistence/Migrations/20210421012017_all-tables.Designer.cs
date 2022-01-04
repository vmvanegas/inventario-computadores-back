﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mispollos.Persistence.Migrations
{
    [DbContext(typeof(MisPollosContext))]
    [Migration("20210421012017_all-tables")]
    partial class alltables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mispollos.Entities.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTienda")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTienda");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Mispollos.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdTienda")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTienda");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Mispollos.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Mispollos.Entities.PedidoProducto", b =>
                {
                    b.Property<Guid>("IdPedido")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdPedido", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("PedidoProducto");
                });

            modelBuilder.Entity("Mispollos.Entities.Producto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaVencimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdCategoria")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProveedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTienda")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdProveedor");

                    b.HasIndex("IdTienda");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Mispollos.Entities.Proveedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("Mispollos.Entities.Rol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rol");

                    b.HasData(
                        new
                        {
                            Id = new Guid("094ae092-6f85-4016-9abb-f6b742fd550e"),
                            Nombre = "Admin"
                        },
                        new
                        {
                            Id = new Guid("974add88-a622-400a-ac51-9c8cc462ed9a"),
                            Nombre = "Usuario"
                        });
                });

            modelBuilder.Entity("Mispollos.Entities.Tienda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tienda");
                });

            modelBuilder.Entity("Mispollos.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdRol")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTienda")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdTienda");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Mispollos.Entities.Categoria", b =>
                {
                    b.HasOne("Mispollos.Entities.Tienda", "Tienda")
                        .WithMany()
                        .HasForeignKey("IdTienda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tienda");
                });

            modelBuilder.Entity("Mispollos.Entities.Cliente", b =>
                {
                    b.HasOne("Mispollos.Entities.Tienda", "Tienda")
                        .WithMany()
                        .HasForeignKey("IdTienda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tienda");
                });

            modelBuilder.Entity("Mispollos.Entities.Pedido", b =>
                {
                    b.HasOne("Mispollos.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mispollos.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Mispollos.Entities.PedidoProducto", b =>
                {
                    b.HasOne("Mispollos.Entities.Pedido", "Pedido")
                        .WithMany("PedidoProducto")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mispollos.Entities.Producto", "Producto")
                        .WithMany("PedidoProducto")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Mispollos.Entities.Producto", b =>
                {
                    b.HasOne("Mispollos.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mispollos.Entities.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("IdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mispollos.Entities.Tienda", "Tienda")
                        .WithMany()
                        .HasForeignKey("IdTienda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Proveedor");

                    b.Navigation("Tienda");
                });

            modelBuilder.Entity("Mispollos.Entities.Usuario", b =>
                {
                    b.HasOne("Mispollos.Entities.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mispollos.Entities.Tienda", "Tienda")
                        .WithMany()
                        .HasForeignKey("IdTienda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Tienda");
                });

            modelBuilder.Entity("Mispollos.Entities.Pedido", b =>
                {
                    b.Navigation("PedidoProducto");
                });

            modelBuilder.Entity("Mispollos.Entities.Producto", b =>
                {
                    b.Navigation("PedidoProducto");
                });
#pragma warning restore 612, 618
        }
    }
}
