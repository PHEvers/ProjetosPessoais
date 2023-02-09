﻿// <auto-generated />
using Cadastros.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cadastros.Infra.Data.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    partial class SQLServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cadastros.Domain.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UFId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Cadastros.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF_CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Fornecedors");
                });

            modelBuilder.Entity("Cadastros.Domain.Entities.Telefones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FornecedorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Cadastros.Domain.Entities.UF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UF");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "AC"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "AL"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "AP"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "AM"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "BA"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "GO"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "MA"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "CE"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "ES"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "MT"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "MS"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "MG"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "PA"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "PB"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "PR"
                        },
                        new
                        {
                            Id = 16,
                            Nome = "PE"
                        },
                        new
                        {
                            Id = 17,
                            Nome = "PI"
                        },
                        new
                        {
                            Id = 18,
                            Nome = "RJ"
                        },
                        new
                        {
                            Id = 19,
                            Nome = "RN"
                        },
                        new
                        {
                            Id = 20,
                            Nome = "RS"
                        },
                        new
                        {
                            Id = 21,
                            Nome = "RO"
                        },
                        new
                        {
                            Id = 22,
                            Nome = "RR"
                        },
                        new
                        {
                            Id = 23,
                            Nome = "SC"
                        },
                        new
                        {
                            Id = 24,
                            Nome = "SP"
                        },
                        new
                        {
                            Id = 25,
                            Nome = "SE"
                        },
                        new
                        {
                            Id = 26,
                            Nome = "TO"
                        },
                        new
                        {
                            Id = 27,
                            Nome = "DF"
                        });
                });

            modelBuilder.Entity("Cadastros.Domain.Entities.Fornecedor", b =>
                {
                    b.HasOne("Cadastros.Domain.Entities.Empresa", null)
                        .WithMany("ListaFornecedor")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cadastros.Domain.Entities.Empresa", b =>
                {
                    b.Navigation("ListaFornecedor");
                });
#pragma warning restore 612, 618
        }
    }
}
