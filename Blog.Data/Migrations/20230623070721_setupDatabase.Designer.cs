﻿// <auto-generated />
using System;
using Blog.dATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.dATA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230623070721_setupDatabase")]
    partial class setupDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DelatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DelatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelate")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d4d5fc25-bffa-4b10-92fe-9511dd433194"),
                            CategoryId = new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(422),
                            ImageId = new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                            IsDelate = false,
                            Title = "Asp.net Core Deneme Makalesi 1",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("6719d5c4-cb83-4b84-b6f6-66f6696cba9b"),
                            CategoryId = new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                            Content = "Visual Studio of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedDate = new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(442),
                            ImageId = new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                            IsDelate = false,
                            Title = "Visual Studio  Deneme Makalesi 1",
                            ViewCount = 10
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DelatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DelatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelate")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(628),
                            IsDelate = false,
                            Name = "ASP .NET Core"
                        },
                        new
                        {
                            Id = new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(631),
                            IsDelate = false,
                            Name = "Visual Studio"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DelatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DelatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelate")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(712),
                            FileName = "images/testimage",
                            FileType = "jpeg",
                            IsDelate = false
                        },
                        new
                        {
                            Id = new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(725),
                            FileName = "images/vstesttestimage",
                            FileType = "png",
                            IsDelate = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
