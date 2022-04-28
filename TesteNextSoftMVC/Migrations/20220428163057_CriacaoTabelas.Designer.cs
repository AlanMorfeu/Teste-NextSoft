﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteNextSoftMVC.Models;

namespace TesteNextSoftMVC.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220428163057_CriacaoTabelas")]
    partial class CriacaoTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteNextSoftMVC.Models.Condominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Condominio");
                });

            modelBuilder.Entity("TesteNextSoftMVC.Models.Familia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Apto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Condominio")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Condominio");

                    b.ToTable("Familia");
                });

            modelBuilder.Entity("TesteNextSoftMVC.Models.Morador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Familia")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Familia");

                    b.ToTable("Morador");
                });

            modelBuilder.Entity("TesteNextSoftMVC.Models.Familia", b =>
                {
                    b.HasOne("TesteNextSoftMVC.Models.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("Id_Condominio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TesteNextSoftMVC.Models.Morador", b =>
                {
                    b.HasOne("TesteNextSoftMVC.Models.Familia", "Familia")
                        .WithMany()
                        .HasForeignKey("Id_Familia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
