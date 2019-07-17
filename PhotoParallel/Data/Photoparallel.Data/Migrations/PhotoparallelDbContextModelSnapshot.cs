﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Photoparallel.Data;

namespace Photoparallel.Data.Migrations
{
    [DbContext(typeof(PhotoparallelDbContext))]
    partial class PhotoparallelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.CreditCard", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreditCardType");

                    b.Property<string>("CustomerId");

                    b.Property<string>("Cvc2");

                    b.Property<string>("ExpirationDate");

                    b.Property<string>("Number");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.CreditCompany", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Interest");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CreditCompanies");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.CreditContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActiveUntil");

                    b.Property<string>("Address");

                    b.Property<string>("CreditCompanyId");

                    b.Property<int>("CreditStatus");

                    b.Property<string>("CustomerId");

                    b.Property<string>("IdNumber");

                    b.Property<DateTime>("IssuedOn");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("PricePerMonth");

                    b.Property<decimal>("Salary");

                    b.Property<string>("Ucn");

                    b.HasKey("Id");

                    b.HasIndex("CreditCompanyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("CreditContracts");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId");

                    b.Property<string>("InvoiceNumber");

                    b.Property<DateTime>("IssuedOn");

                    b.Property<string>("ShippingAddress");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("CreditCardId");

                    b.Property<string>("CustomerId");

                    b.Property<DateTime?>("EstimatedDeliveryDate");

                    b.Property<int?>("InvoiceId");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("PaymentStatus");

                    b.Property<int>("PaymentType");

                    b.Property<string>("Recipient");

                    b.Property<string>("RecipientPhoneNumber");

                    b.Property<decimal>("Shipping");

                    b.Property<string>("ShippingAddress");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("CreditCardId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InvoiceId")
                        .IsUnique()
                        .HasFilter("[InvoiceId] IS NOT NULL");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.OrderProduct", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Description");

                    b.Property<bool>("Hide");

                    b.Property<int>("InPendingOrders");

                    b.Property<bool>("IsRented");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("PricePerDay");

                    b.Property<int>("ProductStatus");

                    b.Property<int>("ProductType");

                    b.Property<int>("Quantity");

                    b.Property<int?>("Warranty");

                    b.Property<int>("WarrantyStatus");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreditCardId");

                    b.Property<string>("CustomerId");

                    b.Property<int?>("InvoiceId");

                    b.Property<DateTime>("RentedOn");

                    b.Property<DateTime?>("ReturnedOn");

                    b.Property<string>("ShippingAddress");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("CreditCardId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InvoiceId")
                        .IsUnique()
                        .HasFilter("[InvoiceId] IS NOT NULL");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.RentProduct", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("RentId");

                    b.Property<int>("Quantity");

                    b.HasKey("ProductId", "RentId");

                    b.HasIndex("RentId");

                    b.ToTable("RentProducts");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Photoparallel.Data.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Photoparallel.Data.Models.CreditCard", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.ApplicationUser", "Customer")
                        .WithMany("CreditCards")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.CreditContract", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.CreditCompany", "CreditCompany")
                        .WithMany("Contracts")
                        .HasForeignKey("CreditCompanyId");

                    b.HasOne("Photoparallel.Data.Models.ApplicationUser", "Customer")
                        .WithMany("CreditContracts")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Photoparallel.Data.Models.Order", "Order")
                        .WithOne("CreditContract")
                        .HasForeignKey("Photoparallel.Data.Models.CreditContract", "OrderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Image", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Invoice", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.ApplicationUser", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Order", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.CreditCard", "CreditCard")
                        .WithMany("Orders")
                        .HasForeignKey("CreditCardId");

                    b.HasOne("Photoparallel.Data.Models.ApplicationUser", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Photoparallel.Data.Models.Invoice", "Invoice")
                        .WithOne("Order")
                        .HasForeignKey("Photoparallel.Data.Models.Order", "InvoiceId");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.OrderProduct", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Photoparallel.Data.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Photoparallel.Data.Models.Rent", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.CreditCard", "CreditCard")
                        .WithMany("Rents")
                        .HasForeignKey("CreditCardId");

                    b.HasOne("Photoparallel.Data.Models.ApplicationUser", "Customer")
                        .WithMany("Rents")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Photoparallel.Data.Models.Invoice", "Invoice")
                        .WithOne("Rent")
                        .HasForeignKey("Photoparallel.Data.Models.Rent", "InvoiceId");
                });

            modelBuilder.Entity("Photoparallel.Data.Models.RentProduct", b =>
                {
                    b.HasOne("Photoparallel.Data.Models.Product", "Product")
                        .WithMany("Rents")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Photoparallel.Data.Models.Rent", "Rent")
                        .WithMany("Products")
                        .HasForeignKey("RentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
