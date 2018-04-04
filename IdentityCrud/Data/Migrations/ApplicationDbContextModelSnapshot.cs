﻿// <auto-generated />
using IdentityCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace IdentityCrud.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityCrud.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsEnabled")
                        .HasColumnName("IsEnabled");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

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

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("IdentityCrud.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddUserId")
                        .HasColumnName("AddId");

                    b.Property<string>("AddressOfSupplier")
                        .IsRequired()
                        .HasColumnName("AddressOfSupplier")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("CreateIPAddress")
                        .HasColumnName("CreateIP");

                    b.Property<string>("DescriptionOfProduct")
                        .IsRequired()
                        .HasColumnName("DescriptionOfProduct")
                        .HasColumnType("TEXT")
                        .HasMaxLength(3000);

                    b.Property<DateTime>("EntryDate")
                        .HasColumnName("EntryDate")
                        .HasColumnType("DATE");

                    b.Property<int>("InitialCount")
                        .HasColumnName("InitialCount");

                    b.Property<string>("LastUpdateIPAddress")
                        .HasColumnName("LastIP");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("Update");

                    b.Property<string>("LastUpdateUserId")
                        .HasColumnName("LastUpdateId");

                    b.Property<string>("NameOfSupplier")
                        .IsRequired()
                        .HasColumnName("NameOfSupplier")
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfSuppliedProduct")
                        .HasColumnName("NumberOfSuppliedProduct");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.Property<float>("SuppliedProductUnitPrice")
                        .HasColumnName("SuppliedProductUnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("IdentityCrud.Models.Exit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddUserId")
                        .HasColumnName("AddId");

                    b.Property<string>("AddressOfUser")
                        .IsRequired()
                        .HasColumnName("AddressOfUser")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<string>("CreateIPAddress")
                        .HasColumnName("CreateIP");

                    b.Property<string>("DemandNoteNo")
                        .IsRequired()
                        .HasColumnName("DemandnoteNo")
                        .HasMaxLength(100);

                    b.Property<int?>("EntryId")
                        .HasColumnName("EntryId");

                    b.Property<string>("LastUpdateIPAddress")
                        .HasColumnName("LastIP");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("Update");

                    b.Property<string>("LastUpdateUserId")
                        .HasColumnName("LastUpdateId");

                    b.Property<string>("NameOfUser")
                        .IsRequired()
                        .HasColumnName("NameOfUser")
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfReceivedProduct")
                        .HasColumnName("NumberOfReceivedProduct");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.Property<DateTime>("ReceiveDate")
                        .HasColumnName("ReceiveDate")
                        .HasColumnType("DATE");

                    b.Property<int>("TotalNoOfProductAfterdeduction")
                        .HasColumnName("TotalNoOfProductAfterdeduction");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Exits");
                });

            modelBuilder.Entity("IdentityCrud.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddUserId")
                        .HasColumnName("AddId");

                    b.Property<string>("CreateIPAddress")
                        .HasColumnName("CreateIP");

                    b.Property<int>("CurrentStoreValue")
                        .HasColumnName("CurrentStoreValue");

                    b.Property<string>("LastUpdateIPAddress")
                        .HasColumnName("LastIP");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("Update");

                    b.Property<string>("LastUpdateUserId")
                        .HasColumnName("LastUpdateId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("ProductCategoryId")
                        .HasColumnName("ProductCategoryId");

                    b.Property<int>("ProductTypeId")
                        .HasColumnName("ProductTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("IdentityCrud.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddUserId")
                        .HasColumnName("AddId");

                    b.Property<string>("CreateIPAddress")
                        .HasColumnName("CreateIP");

                    b.Property<string>("LastUpdateIPAddress")
                        .HasColumnName("LastIP");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("Update");

                    b.Property<string>("LastUpdateUserId")
                        .HasColumnName("LastUpdateId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("IdentityCrud.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddUserId")
                        .HasColumnName("AddId");

                    b.Property<string>("CreateIPAddress")
                        .HasColumnName("CreateIP");

                    b.Property<string>("LastUpdateIPAddress")
                        .HasColumnName("LastIP");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnName("Update");

                    b.Property<string>("LastUpdateUserId")
                        .HasColumnName("LastUpdateId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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
                        .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("IdentityCrud.Models.Entry", b =>
                {
                    b.HasOne("IdentityCrud.Models.Product", "ProductName")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityCrud.Models.Exit", b =>
                {
                    b.HasOne("IdentityCrud.Models.Entry", "Entry")
                        .WithMany()
                        .HasForeignKey("EntryId");

                    b.HasOne("IdentityCrud.Models.Product", "ProductName")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityCrud.Models.Product", b =>
                {
                    b.HasOne("IdentityCrud.Models.ProductCategory", "ProductCategoryName")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IdentityCrud.Models.ProductType", "ProductTypeName")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IdentityCrud.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IdentityCrud.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IdentityCrud.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IdentityCrud.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
