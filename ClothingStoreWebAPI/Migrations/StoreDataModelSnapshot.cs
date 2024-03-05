﻿// <auto-generated />
using System;
using ClothingStoreWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothingStoreWebAPI.Migrations
{
    [DbContext(typeof(StoreData))]
    partial class StoreDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Homme"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Femme"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Enfant"
                        });
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<string>("ImageUrls")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("OrderProductId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            OrderProductId = 0,
                            Status = "Terminé",
                            UserId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            OrderProductId = 0,
                            Status = "En cours",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderProductId"));

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            OrderProductId = 3,
                            Price = 69.0,
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            OrderProductId = 4,
                            Price = 100.0,
                            ProductId = 2,
                            Quantity = 2
                        },
                        new
                        {
                            OrderProductId = 1,
                            Price = 49.0,
                            ProductId = 1,
                            Quantity = 5
                        },
                        new
                        {
                            OrderProductId = 2,
                            Price = 129.0,
                            ProductId = 2,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageID")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Chemise élégante pour hommes",
                            ImageID = 0,
                            ImageUrl = "vet",
                            Name = "Chemise homme",
                            Price = 49.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Description = "Robe élégante pour les occasions spéciales",
                            ImageID = 0,
                            ImageUrl = "rob",
                            Name = "Robe de soirée",
                            Price = 129.0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            Description = "Jean slim pour un look décontracté",
                            ImageID = 0,
                            ImageUrl = "jean",
                            Name = "Jean slim",
                            Price = 69.0
                        });
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            DateOfBirth = new DateOnly(2000, 1, 1),
                            Email = "charles.Victors@email.com",
                            FirstName = "Charles",
                            LastName = "Victor",
                            Password = "charlesV"
                        },
                        new
                        {
                            UserId = 2,
                            DateOfBirth = new DateOnly(1998, 5, 23),
                            Email = "charles.Duhigg@email.com",
                            FirstName = "Charles",
                            LastName = "Duhigg",
                            Password = "charlesD"
                        },
                        new
                        {
                            UserId = 3,
                            DateOfBirth = new DateOnly(1998, 5, 23),
                            Email = "Victor.Hugo@email.com",
                            FirstName = "Victor",
                            LastName = "Hugo",
                            Password = "VictorH"
                        });
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Order", b =>
                {
                    b.HasOne("ClothingStoreWebAPI.Entities.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.OrderProduct", b =>
                {
                    b.HasOne("ClothingStoreWebAPI.Entities.Order", null)
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId");

                    b.HasOne("ClothingStoreWebAPI.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Product", b =>
                {
                    b.HasOne("ClothingStoreWebAPI.Entities.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("ClothingStoreWebAPI.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
