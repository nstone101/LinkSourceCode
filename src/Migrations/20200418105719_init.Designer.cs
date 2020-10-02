﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using src.Data;
using src.Enum;
using System;

namespace src.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200418105719_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("src.Models.Contact", b =>
                {
                    b.Property<Guid>("contactId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("contactName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("customerId");

                    b.Property<string>("description")
                        .HasMaxLength(200);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("linkedin")
                        .HasMaxLength(100);

                    b.Property<string>("phone")
                        .HasMaxLength(20);

                    b.Property<string>("secondaryEmail")
                        .HasMaxLength(100);

                    b.Property<string>("thumbUrl")
                        .HasMaxLength(255);

                    b.Property<string>("website")
                        .HasMaxLength(100);

                    b.HasKey("contactId");

                    b.HasIndex("customerId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("src.Models.Customer", b =>
                {
                    b.Property<Guid>("customerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("address")
                        .HasMaxLength(100);

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("customerType");

                    b.Property<string>("description")
                        .HasMaxLength(200);

                    b.Property<string>("email")
                        .HasMaxLength(100);

                    b.Property<string>("linkedin")
                        .HasMaxLength(100);

                    b.Property<string>("phone")
                        .HasMaxLength(20);

                    b.Property<string>("thumbUrl")
                        .HasMaxLength(255);

                    b.Property<string>("website")
                        .HasMaxLength(100);

                    b.HasKey("customerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("src.Models.Contact", b =>
                {
                    b.HasOne("src.Models.Customer", "customer")
                        .WithMany("contacts")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
