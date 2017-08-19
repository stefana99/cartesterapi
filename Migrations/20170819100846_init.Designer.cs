﻿// <auto-generated />
using CarTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CarTest.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20170819100846_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarTest.Models.BasicCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Plate");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BasicCars");
                });

            modelBuilder.Entity("CarTest.Models.BasicUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BasicUser");
                });

            modelBuilder.Entity("CarTest.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Plate");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarTest.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChannelId");

                    b.Property<string>("ConversationId");

                    b.Property<string>("FaceBookUserId");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<string>("RecipientId");

                    b.Property<string>("ServiceUrl");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CarTest.Models.BasicCar", b =>
                {
                    b.HasOne("CarTest.Models.BasicUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CarTest.Models.Car", b =>
                {
                    b.HasOne("CarTest.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}