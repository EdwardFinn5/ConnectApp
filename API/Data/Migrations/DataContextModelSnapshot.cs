﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("API.Entities.ColUser", b =>
                {
                    b.Property<int>("ColUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColUserId");

                    b.ToTable("ColUsers");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.Property<int>("CollegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CollegeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CollegeId");

                    b.ToTable("Colleges");
                });

            modelBuilder.Entity("API.Entities.EmpUser", b =>
                {
                    b.Property<int>("EmpUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmpUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpUserId");

                    b.ToTable("EmpUsers");
                });

            modelBuilder.Entity("API.Entities.HsUser", b =>
                {
                    b.Property<int>("HsUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HsUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HsUserId");

                    b.ToTable("HsUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
