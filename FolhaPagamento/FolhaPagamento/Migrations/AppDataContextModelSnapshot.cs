﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FolhaPagamento.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("API.Models.Folha", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ano")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("impostoFgts")
                        .HasColumnType("REAL");

                    b.Property<float?>("impostoInss")
                        .HasColumnType("REAL");

                    b.Property<float?>("impostoIrrf")
                        .HasColumnType("REAL");

                    b.Property<int?>("mes")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("salarioBruto")
                        .HasColumnType("REAL");

                    b.Property<float?>("salarioLiquido")
                        .HasColumnType("REAL");

                    b.Property<float?>("valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("TabelaFolha");
                });

            modelBuilder.Entity("API.Models.Funcionario", b =>
                {
                    b.Property<int?>("funcionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("funcionarioId");

                    b.ToTable("TabelaFuncionario");
                });
#pragma warning restore 612, 618
        }
    }
}
