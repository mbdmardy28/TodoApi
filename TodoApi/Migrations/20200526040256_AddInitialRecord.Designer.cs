﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Data;

namespace TodoApi.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20200526040256_AddInitialRecord")]
    partial class AddInitialRecord
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoApi.Model.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Task");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Prepare Demo Database",
                            Status = "Closed",
                            Title = "Create Task Database"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Prepare Demo App",
                            Status = "Active",
                            Title = "Create Demo App"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Conduct Regression Testing",
                            Status = "New",
                            Title = "Test Demo App"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Prepare Demo Database",
                            Status = "New",
                            Title = "Create Task Database"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
