﻿// <auto-generated />
using Blazor8CRUD.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor8CRUD.Migrations
{
    [DbContext(typeof(MyDbcontext))]
    [Migration("20231123140354_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blazor8CRUD.DbModels.DIMPersonelType", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DIMPersonelTypes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Title = "حقیقی"
                        },
                        new
                        {
                            ID = 2,
                            Title = "حقوقی"
                        });
                });

            modelBuilder.Entity("Blazor8CRUD.DbModels.Personel", b =>
                {
                    b.Property<string>("CodeMeli")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDDimPersonelType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodeMeli");

                    b.HasIndex("IDDimPersonelType");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("Blazor8CRUD.DbModels.Personel", b =>
                {
                    b.HasOne("Blazor8CRUD.DbModels.DIMPersonelType", "DIMPersonelType")
                        .WithMany()
                        .HasForeignKey("IDDimPersonelType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DIMPersonelType");
                });
#pragma warning restore 612, 618
        }
    }
}
