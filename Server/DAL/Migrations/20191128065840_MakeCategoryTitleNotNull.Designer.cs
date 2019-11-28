﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(BilSoftTaskContext))]
    [Migration("20191128065840_MakeCategoryTitleNotNull")]
    partial class MakeCategoryTitleNotNull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad65906b-6856-44b4-8400-8880419bcffe"),
                            Title = "Category 1"
                        },
                        new
                        {
                            Id = new Guid("0195579a-6c52-4759-9360-49957bad6991"),
                            Title = "Category 2"
                        },
                        new
                        {
                            Id = new Guid("5c6be1bc-8975-43a8-862f-4a9292c0392d"),
                            Title = "Category 3"
                        },
                        new
                        {
                            Id = new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"),
                            Title = "Category 4"
                        },
                        new
                        {
                            Id = new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"),
                            Title = "Category 5"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f785a54a-6125-4ae5-86e1-18019ed6f23f"),
                            CategoryId = new Guid("ad65906b-6856-44b4-8400-8880419bcffe"),
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = new Guid("7406fc96-a78f-4194-bf1f-26e1b77cc4b2"),
                            CategoryId = new Guid("ad65906b-6856-44b4-8400-8880419bcffe"),
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = new Guid("5ec671a8-24eb-4e5b-aecb-02d05a3c361e"),
                            CategoryId = new Guid("5c6be1bc-8975-43a8-862f-4a9292c0392d"),
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = new Guid("03bdf287-90d4-446c-a08f-bfdaf7a3452a"),
                            CategoryId = new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"),
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = new Guid("dd879da5-bf98-4d60-9885-0e258316fa6c"),
                            CategoryId = new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"),
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = new Guid("2cf0047b-3cbe-4cc6-aa8b-d692b13c121f"),
                            CategoryId = new Guid("8f55e482-6f79-4aeb-959b-c4d5d24322b7"),
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = new Guid("00fa52ea-c324-44ee-a0b7-765f75e674d6"),
                            CategoryId = new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"),
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = new Guid("5edaed8f-d8a2-48a3-a0f0-1c7c52b39eac"),
                            CategoryId = new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"),
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = new Guid("3735c6c6-f9b1-4249-9a3b-794da2d408d4"),
                            CategoryId = new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"),
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = new Guid("56bf4b57-3ebd-4436-a821-6c0575f85686"),
                            CategoryId = new Guid("a60bc115-d71f-4bc7-ac49-91da79dabb09"),
                            Title = "Product 10"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.HasOne("DAL.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
