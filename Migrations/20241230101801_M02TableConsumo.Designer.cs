﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mf_dev_backend_2024.Data;

#nullable disable

namespace mf_dev_backend_2024.Migrations
{
    [DbContext(typeof(mf_dev_backend_2024Context))]
    [Migration("20241230101801_M02TableConsumo")]
    partial class M02TableConsumo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("mf_dev_backend_2024.Models.Consumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Km")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Consumos");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Consumo", b =>
                {
                    b.HasOne("mf_dev_backend_2024.Models.Veiculo", "Veiculo")
                        .WithMany("Consumos")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Veiculo", b =>
                {
                    b.Navigation("Consumos");
                });
#pragma warning restore 612, 618
        }
    }
}