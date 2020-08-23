﻿// <auto-generated />
using IS_BartenderAppProject_MV.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IS_BartenderAppProject_MV.Migrations
{
    [DbContext(typeof(DrinksContext))]
    [Migration("20200820053416_ingredients added")]
    partial class ingredientsadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IS_BartenderAppProject_MV.Models.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DrinkCost")
                        .HasColumnType("float");

                    b.Property<string>("DrinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
