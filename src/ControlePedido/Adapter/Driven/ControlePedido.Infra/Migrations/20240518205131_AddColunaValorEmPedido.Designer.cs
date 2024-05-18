﻿// <auto-generated />
using System;
using ControlePedido.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControlePedido.Infra.Migrations
{
    [DbContext(typeof(ControlePedidoContext))]
    [Migration("20240518205131_AddColunaValorEmPedido")]
    partial class AddColunaValorEmPedido
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ControlePedido.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataHoraFim")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataHoraInicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos", (string)null);
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.PedidoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("PedidoItens", (string)null);
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.PedidoPagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CodigoTransacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataHoraPagamento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("Pagamentos", (string)null);
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Categoria")
                        .HasColumnType("integer");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Cliente", b =>
                {
                    b.OwnsOne("ControlePedido.Domain.ValueObjects.CPF", "Cpf", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Cpf");

                            b1.HasKey("ClienteId");

                            b1.HasIndex("Numero")
                                .IsUnique();

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.OwnsOne("ControlePedido.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Endereco")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Email");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.Navigation("Cpf")
                        .IsRequired();

                    b.Navigation("Email")
                        .IsRequired();
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("ControlePedido.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.PedidoItem", b =>
                {
                    b.HasOne("ControlePedido.Domain.Entities.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlePedido.Domain.Entities.Produto", "Produto")
                        .WithMany("ItensPedido")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.PedidoPagamento", b =>
                {
                    b.HasOne("ControlePedido.Domain.Entities.Pedido", "Pedido")
                        .WithOne("Pagamento")
                        .HasForeignKey("ControlePedido.Domain.Entities.PedidoPagamento", "PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Produto", b =>
                {
                    b.OwnsOne("ControlePedido.Domain.ValueObjects.Imagem", "Imagem", b1 =>
                        {
                            b1.Property<Guid>("ProdutoId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Extensao")
                                .IsRequired()
                                .HasMaxLength(10)
                                .HasColumnType("character varying(10)")
                                .HasColumnName("ExtensaoImagem");

                            b1.Property<string>("Nome")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("NomeImagem");

                            b1.Property<string>("Url")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("UrlImagem");

                            b1.HasKey("ProdutoId");

                            b1.ToTable("Produtos");

                            b1.WithOwner()
                                .HasForeignKey("ProdutoId");
                        });

                    b.Navigation("Imagem")
                        .IsRequired();
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("Itens");

                    b.Navigation("Pagamento")
                        .IsRequired();
                });

            modelBuilder.Entity("ControlePedido.Domain.Entities.Produto", b =>
                {
                    b.Navigation("ItensPedido");
                });
#pragma warning restore 612, 618
        }
    }
}