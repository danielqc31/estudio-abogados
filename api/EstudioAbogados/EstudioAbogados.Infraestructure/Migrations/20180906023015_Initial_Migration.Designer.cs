﻿// <auto-generated />
using EstudioAbogados.Infraestructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EstudioAbogados.Infraestructure.Migrations
{
    [DbContext(typeof(EstudioAbogadosDbContext))]
    [Migration("20180906023015_Initial_Migration")]
    partial class Initial_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EstudioAbogados.Domain.Abogado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApMaterno")
                        .IsRequired()
                        .HasColumnName("APMATERNO")
                        .HasMaxLength(100);

                    b.Property<string>("ApPaterno")
                        .IsRequired()
                        .HasColumnName("APPATERNO")
                        .HasMaxLength(100);

                    b.Property<string>("CodColegioAB")
                        .HasColumnName("COD_COLEGIOAB")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreationDate");

                    b.Property<long>("CreationUserId");

                    b.Property<DateTime?>("DeletionDate");

                    b.Property<long?>("DeletionUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<long?>("LastModificacionUserId");

                    b.Property<DateTime?>("LastModificationDate");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnName("NOMBRES")
                        .HasMaxLength(500);

                    b.Property<string>("NroDocumento")
                        .IsRequired()
                        .HasColumnName("NRODOCUMENTO")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("TB_ABOGADO");
                });
#pragma warning restore 612, 618
        }
    }
}
