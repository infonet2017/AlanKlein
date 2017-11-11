﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PostWall.Model;
using System;

namespace PostWall.Migrations
{
    [DbContext(typeof(InfoDbContext))]
    [Migration("20171031045937_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PostWall.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Description");

                    b.Property<int?>("PostWallID");

                    b.Property<string>("Teacher");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PostWallID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("PostWall.Model.PostWall", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Module");

                    b.HasKey("ID");

                    b.ToTable("PostWall");
                });

            modelBuilder.Entity("PostWall.Model.Post", b =>
                {
                    b.HasOne("PostWall.Model.PostWall")
                        .WithMany("Posts")
                        .HasForeignKey("PostWallID");
                });
#pragma warning restore 612, 618
        }
    }
}
