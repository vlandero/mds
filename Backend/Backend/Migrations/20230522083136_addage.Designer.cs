﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ShareLocationContext))]
    [Migration("20230522083136_addage")]
    partial class addage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Backend.Models.Connected.Connected", b =>
                {
                    b.Property<Guid>("Id1")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id2")
                        .HasColumnType("uuid");

                    b.Property<Guid>("User1Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("User2Id")
                        .HasColumnType("uuid");

                    b.HasKey("Id1", "Id2");

                    b.HasIndex("User1Id");

                    b.HasIndex("User2Id");

                    b.ToTable("Connecteds");
                });

            modelBuilder.Entity("Backend.Models.Rejected.Rejected", b =>
                {
                    b.Property<Guid>("Id1")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id2")
                        .HasColumnType("uuid");

                    b.Property<Guid>("User1Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("User2Id")
                        .HasColumnType("uuid");

                    b.HasKey("Id1", "Id2");

                    b.HasIndex("User1Id");

                    b.HasIndex("User2Id");

                    b.ToTable("Rejecteds");
                });

            modelBuilder.Entity("Backend.Models.User.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("Photos")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Backend.Models.Connected.Connected", b =>
                {
                    b.HasOne("Backend.Models.User.User", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.User.User", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("Backend.Models.Rejected.Rejected", b =>
                {
                    b.HasOne("Backend.Models.User.User", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.User.User", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });
#pragma warning restore 612, 618
        }
    }
}
