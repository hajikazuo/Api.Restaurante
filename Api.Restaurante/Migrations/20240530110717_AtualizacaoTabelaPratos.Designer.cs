﻿// <auto-generated />
using Api.Restaurante.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Restaurante.Migrations
{
    [DbContext(typeof(RestauranteContext))]
    [Migration("20240530110717_AtualizacaoTabelaPratos")]
    partial class AtualizacaoTabelaPratos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.Restaurante.Entities.Prato", b =>
                {
                    b.Property<int>("PratoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PratoId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("PratoDescricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PratoNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("PratoValorUnit")
                        .HasColumnType("float");

                    b.Property<string>("UrlImg")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("PratoId");

                    b.ToTable("Pratos");
                });
#pragma warning restore 612, 618
        }
    }
}