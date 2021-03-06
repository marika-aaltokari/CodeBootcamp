// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesBookshelf.Data;

namespace RazorPagesBookshelf.Migrations
{
    [DbContext(typeof(RazorPagesBookshelfContext))]
    [Migration("20210407052215_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesBookshelf.Models.Bookshelf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Favorite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SavingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Bookshelf");
                });
#pragma warning restore 612, 618
        }
    }
}
