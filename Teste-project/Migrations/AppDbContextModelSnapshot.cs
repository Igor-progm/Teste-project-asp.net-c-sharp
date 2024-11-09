﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teste_project.Models;

#nullable disable

namespace Teste_project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Teste_project.Models.Alimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcucaresTotais")
                        .HasColumnType("int");

                    b.Property<int>("Calcio")
                        .HasColumnType("int");

                    b.Property<int>("Calorias")
                        .HasColumnType("int");

                    b.Property<int>("Caorboidratos")
                        .HasColumnType("int");

                    b.Property<int>("Ferro")
                        .HasColumnType("int");

                    b.Property<int>("FibrasAlimentares")
                        .HasColumnType("int");

                    b.Property<int>("GordurasSaturadas")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Proteinas")
                        .HasColumnType("int");

                    b.Property<int>("Sodio")
                        .HasColumnType("int");

                    b.Property<int>("VitaminaB1")
                        .HasColumnType("int");

                    b.Property<int>("VitaminaB2")
                        .HasColumnType("int");

                    b.Property<int>("VitaminaB6")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alimentos");
                });
#pragma warning restore 612, 618
        }
    }
}