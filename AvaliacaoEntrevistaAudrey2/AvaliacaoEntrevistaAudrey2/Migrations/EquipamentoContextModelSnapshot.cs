﻿// <auto-generated />
using System;
using AvaliacaoEntrevistaAudrey2.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AvaliacaoEntrevistaAudrey2.Migrations
{
    [DbContext(typeof(EquipamentoContext))]
    partial class EquipamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvaliacaoEntrevistaAudrey2.Models.Equipamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentificadorEquipamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SentidoVia")
                        .HasColumnType("bit");

                    b.Property<int?>("SituacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("UfDestinoId")
                        .HasColumnType("int");

                    b.Property<int?>("UfOrigemId")
                        .HasColumnType("int");

                    b.Property<int>("sentidoLeitura")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SituacaoId");

                    b.HasIndex("UfDestinoId");

                    b.HasIndex("UfOrigemId");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("AvaliacaoEntrevistaAudrey2.Models.Estados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("AvaliacaoEntrevistaAudrey2.Models.Situacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cacelado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Situacao");
                });

            modelBuilder.Entity("AvaliacaoEntrevistaAudrey2.Models.Equipamento", b =>
                {
                    b.HasOne("AvaliacaoEntrevistaAudrey2.Models.Situacao", "Situacao")
                        .WithMany()
                        .HasForeignKey("SituacaoId");

                    b.HasOne("AvaliacaoEntrevistaAudrey2.Models.Estados", "UfDestino")
                        .WithMany()
                        .HasForeignKey("UfDestinoId");

                    b.HasOne("AvaliacaoEntrevistaAudrey2.Models.Estados", "UfOrigem")
                        .WithMany()
                        .HasForeignKey("UfOrigemId");

                    b.Navigation("Situacao");

                    b.Navigation("UfDestino");

                    b.Navigation("UfOrigem");
                });
#pragma warning restore 612, 618
        }
    }
}
