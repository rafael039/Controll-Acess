﻿// <auto-generated />
using Control_Acess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Control_Acess.Migrations
{
    [DbContext(typeof(UsuarioContext))]
    [Migration("20211119201805_AtualizacaoBanco")]
    partial class AtualizacaoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Control_Acess.Models.UsuarioModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("idade")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
