﻿// <auto-generated />
using System;
using Examen_2__Josue_David.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen_2__Josue_David.Migrations
{
    [DbContext(typeof(GestionDeTiendaDbContext))]
    [Migration("20240727085502_TablasDePrestamo")]
    partial class TablasDePrestamo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen_2__Josue_David.Entity.ClienteEntity", b =>
                {
                    b.Property<Guid>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ClienteId");

                    b.Property<string>("ClienteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cliente_name");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("identity_number");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente", "dto");
                });

            modelBuilder.Entity("Examen_2__Josue_David.Entity.PlandePagoEntity", b =>
                {
                    b.Property<Guid>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Prestamo_Id");

                    b.Property<int>("Day")
                        .HasColumnType("int")
                        .HasColumnName("Dias");

                    b.Property<double>("Interests")
                        .HasColumnType("float")
                        .HasColumnName("Intereses");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dia_de_Creacion");

                    b.Property<float>("MainBalanceSheet")
                        .HasColumnType("real")
                        .HasColumnName("Balance_Principal");

                    b.Property<DateTime>("Paymentdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_de_Pago");

                    b.Property<Guid?>("PrestamoEntityClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Principal")
                        .HasColumnType("real")
                        .HasColumnName("Principal");

                    b.Property<double>("levelPaymentWithSVSD")
                        .HasColumnType("float")
                        .HasColumnName("Nivel_Pago_Con_VSD");

                    b.Property<float>("levelPaymentWithoutVSD")
                        .HasColumnType("real")
                        .HasColumnName("Nivel_Pago_Sin_VSD");

                    b.HasKey("LoanId");

                    b.HasIndex("PrestamoEntityClienteId");

                    b.ToTable("cliente_planepago", "dto");
                });

            modelBuilder.Entity("Examen_2__Josue_David.Entity.PrestamoEntity", b =>
                {
                    b.Property<Guid>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Cliente_Id");

                    b.Property<Guid?>("ClienteEntityClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("InterestRate")
                        .HasColumnType("int")
                        .HasColumnName("Tasa_de_Interes");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Prestamo");

                    b.Property<Guid>("LoanId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Prestamo_Id");

                    b.Property<int>("LoanTime")
                        .HasColumnType("int")
                        .HasColumnName("Tiempo_del_Prestamo");

                    b.Property<int>("commission")
                        .HasColumnType("int")
                        .HasColumnName("Comision");

                    b.HasKey("ClienteId");

                    b.HasIndex("ClienteEntityClienteId");

                    b.ToTable("plan_de_pago", "dto");
                });

            modelBuilder.Entity("Examen_2__Josue_David.Entity.PlandePagoEntity", b =>
                {
                    b.HasOne("Examen_2__Josue_David.Entity.PrestamoEntity", "PrestamoEntity")
                        .WithMany("ClientesPlandePago")
                        .HasForeignKey("PrestamoEntityClienteId");

                    b.Navigation("PrestamoEntity");
                });

            modelBuilder.Entity("Examen_2__Josue_David.Entity.PrestamoEntity", b =>
                {
                    b.HasOne("Examen_2__Josue_David.Entity.ClienteEntity", null)
                        .WithMany("Pagos")
                        .HasForeignKey("ClienteEntityClienteId");
                });

            modelBuilder.Entity("Examen_2__Josue_David.Entity.ClienteEntity", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Examen_2__Josue_David.Entity.PrestamoEntity", b =>
                {
                    b.Navigation("ClientesPlandePago");
                });
#pragma warning restore 612, 618
        }
    }
}
