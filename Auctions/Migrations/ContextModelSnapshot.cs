﻿// <auto-generated />
using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace ConsoleApp2.Migrations
{
    [DbContext(typeof(ContextDb))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp2.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("ConsoleApp2.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuctionId");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("ConsoleApp2.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuctionId");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.ToTable("Round");
                });

            modelBuilder.Entity("ConsoleApp2.Provider", b =>
                {
                    b.HasOne("ConsoleApp2.Auction")
                        .WithMany("ProvidersC")
                        .HasForeignKey("AuctionId");
                });

            modelBuilder.Entity("ConsoleApp2.Round", b =>
                {
                    b.HasOne("ConsoleApp2.Auction")
                        .WithMany("RoundsC")
                        .HasForeignKey("AuctionId");
                });
#pragma warning restore 612, 618
        }
    }
}