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
    [Migration("20220305034353_addSaleCountColumnToProducts")]
    partial class addSaleCountColumnToProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VenusDigital.Models.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryBanner")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ParentCategoryBanner")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("VenusDigital.Models.Compare", b =>
                {
                    b.Property<int>("CompareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CompareId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Compare");
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

                    b.Property<int?>("CouponPercent")
                        .HasColumnType("int");

                    b.Property<decimal?>("CouponValue")
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

                    b.HasKey("FeatureId");

                    b.HasIndex("ProductId");

                    b.ToTable("Features");
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

            modelBuilder.Entity("VenusDigital.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AppliedCoupon")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFinally")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProcessed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentTraceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalOrderPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalPriceWithCoupon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("VenusDigital.Models.OrderDetails", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageRefersTo")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("GalleryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductGalleries");
                });

            modelBuilder.Entity("VenusDigital.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryId")
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

                    b.Property<int?>("SaleCount")
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

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewCreateDate")
                        .HasColumnType("datetime2");

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

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("VenusDigital.Models.SelectedCategory", b =>
                {
                    b.Property<int>("SelectedCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("SelectedCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("SelectedCategory");
                });

            modelBuilder.Entity("VenusDigital.Models.Slider", b =>
                {
                    b.Property<int>("SlideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SlideAltName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SlideName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SlideRefersTo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SlideId");

                    b.ToTable("Slider");
                });

            modelBuilder.Entity("VenusDigital.Models.Supports", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AnswerDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AnswerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAnswered")
                        .HasColumnType("bit");

                    b.Property<string>("RequestCode")
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

                    b.Property<string>("UserIpAddress")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("TagId");

                    b.HasIndex("ProductId");

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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PostalInformationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserIdentifierCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.HasKey("WishListId");

                    b.HasIndex("UserId");

                    b.ToTable("WishLists");
                });

            modelBuilder.Entity("VenusDigital.Models.Categories", b =>
                {
                    b.HasOne("VenusDigital.Models.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VenusDigital.Models.Compare", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Compare")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VenusDigital.Models.Users", "Users")
                        .WithMany("Compares")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.Features", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Features")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.Order", b =>
                {
                    b.HasOne("VenusDigital.Models.Users", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.OrderDetails", b =>
                {
                    b.HasOne("VenusDigital.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VenusDigital.Models.Products", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
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
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.Reviews", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VenusDigital.Models.Users", "Users")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.SelectedCategory", b =>
                {
                    b.HasOne("VenusDigital.Models.Categories", "Categories")
                        .WithMany("SelectedCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("SelectedCategory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.Tags", b =>
                {
                    b.HasOne("VenusDigital.Models.Products", "Products")
                        .WithMany("Tags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("VenusDigital.Models.WishLists", b =>
                {
                    b.HasOne("VenusDigital.Models.Users", "Users")
                        .WithMany("WishLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VenusDigital.Models.Categories", b =>
                {
                    b.Navigation("SelectedCategory");
                });

            modelBuilder.Entity("VenusDigital.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("VenusDigital.Models.Products", b =>
                {
                    b.Navigation("Compare");

                    b.Navigation("Features");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductGalleries");

                    b.Navigation("Reviews");

                    b.Navigation("SelectedCategory");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("VenusDigital.Models.Users", b =>
                {
                    b.Navigation("Compares");

                    b.Navigation("Orders");

                    b.Navigation("PostalInformations");

                    b.Navigation("Reviews");

                    b.Navigation("WishLists");
                });
#pragma warning restore 612, 618
        }
    }
}
