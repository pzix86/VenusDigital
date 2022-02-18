﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VenusDigital.Data;

namespace VenusDigital.Migrations
{
    [DbContext(typeof(VenusDigitalContext))]
    [Migration("20220217135828_initFullTables")]
    partial class initFullTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VenusDigital.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFinally")
                        .HasColumnType("bit");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotallPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("VenusDigital.Models.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ParentCategoryBanner")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("ParentName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryId1");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("VenusDigital.Models.Coupons", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CouponCodeCount")
                        .HasColumnType("int");

                    b.Property<int>("CouponPercent")
                        .HasColumnType("int");

                    b.Property<decimal>("CouponValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("VenusDigital.Models.Features", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatureTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FeatureValue")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("FeatureId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("VenusDigital.Models.Items", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<decimal>("ItemTotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("VenusDigital.Models.Newsletters", b =>
                {
                    b.Property<int>("NewsletterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NewslettersSubedUserEmail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("NewsletterId");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("VenusDigital.Models.PostalInformations", b =>
                {
                    b.Property<int>("PostalInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PostalInformationId");

                    b.HasIndex("UserId");

                    b.ToTable("PostalInformations");
                });

            modelBuilder.Entity("VenusDigital.Models.ProductGalleries", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageAltName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageRefersTo")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("GalleryId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("ProductGalleries");
                });

            modelBuilder.Entity("VenusDigital.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ProductInStock")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ProductLongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductMainPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProductOnSalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductQuantityInStock")
                        .HasColumnType("int");

                    b.Property<float>("ProductScore")
                        .HasColumnType("real");

                    b.Property<string>("ProductShortDescription")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("ProductTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<int>("SalePercent")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.Reviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewDescription")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<float>("ReviewScore")
                        .HasColumnType("real");

                    b.Property<string>("ReviewTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductsProductId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("VenusDigital.Models.Supports", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RequestCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RequestDescription")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("RequestTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserEmailAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ContactId");

                    b.ToTable("Supports");
                });

            modelBuilder.Entity("VenusDigital.Models.Tags", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("TagId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("VenusDigital.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("varbinary(1024)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PostalInformationId")
                        .HasColumnType("int");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("WishListId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.WishLists", b =>
                {
                    b.Property<int>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("WishListId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("WishLists");
                });

            modelBuilder.Entity("VenusDigital.Models.Cart", b =>
                {
                    b.HasOne("VenusDigital.Models.Users", "Users")
                        .WithMany("Carts")
                        .HasForeignKey("UsersUserId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.Categories", b =>
                {
                    b.HasOne("VenusDigital.Models.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId1");

                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Categories")
                        .HasForeignKey("ProductsProductId");

                    b.Navigation("Category");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.Features", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Features")
                        .HasForeignKey("ProductsProductId");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.Items", b =>
                {
                    b.HasOne("VenusDigital.Models.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId");

                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Items")
                        .HasForeignKey("ProductsProductId");

                    b.Navigation("Cart");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.PostalInformations", b =>
                {
                    b.HasOne("VenusDigital.Models.Users", "User")
                        .WithMany("PostalInformations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("VenusDigital.Models.ProductGalleries", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("ProductGalleries")
                        .HasForeignKey("ProductsProductId");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.Reviews", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductsProductId");

                    b.HasOne("VenusDigital.Models.Users", "Users")
                        .WithMany("Reviews")
                        .HasForeignKey("UsersUserId");

                    b.Navigation("Products");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.Tags", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Tags")
                        .HasForeignKey("ProductsProductId");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.WishLists", b =>
                {
                    b.HasOne("VenusDigital.Models.Users", "Users")
                        .WithMany("WishLists")
                        .HasForeignKey("UsersUserId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("VenusDigital.Models.Products", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Features");

                    b.Navigation("Items");

                    b.Navigation("ProductGalleries");

                    b.Navigation("Reviews");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("VenusDigital.Models.Users", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("PostalInformations");

                    b.Navigation("Reviews");

                    b.Navigation("WishLists");
                });
#pragma warning restore 612, 618
        }
    }
}