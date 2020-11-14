﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201108012026_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AppUserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.ColPhoto", b =>
                {
                    b.Property<int>("ColPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColPhotoId");

                    b.HasIndex("ColUserId");

                    b.ToTable("ColPhotos");
                });

            modelBuilder.Entity("API.Entities.ColUser", b =>
                {
                    b.Property<int>("ColUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ColEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ColPhone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ColUserName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ColUserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("NickName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ColUserId");

                    b.ToTable("ColUsers");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.Property<int>("CollegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ColUserId")
                        .HasColumnType("int");

                    b.Property<string>("CollegeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeLocation")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("CollegeId");

                    b.HasIndex("ColUserId");

                    b.ToTable("Colleges");
                });

            modelBuilder.Entity("API.Entities.CollegeMajor", b =>
                {
                    b.Property<int>("CollegeId")
                        .HasColumnType("int");

                    b.Property<int>("MajorId")
                        .HasColumnType("int");

                    b.HasKey("CollegeId", "MajorId");

                    b.HasIndex("MajorId");

                    b.ToTable("CollegeMajors");
                });

            modelBuilder.Entity("API.Entities.CollegePrep", b =>
                {
                    b.Property<int>("CollegePrepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AcademicPlus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("ClassYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DreamJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("GPA")
                        .HasColumnType("real");

                    b.Property<DateTime>("GradDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hometown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPlus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CollegePrepId");

                    b.HasIndex("AppUserId");

                    b.ToTable("CollegePreps");
                });

            modelBuilder.Entity("API.Entities.EmpOpp", b =>
                {
                    b.Property<int>("EmpOppId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("ApplyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowToApply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmpOppId");

                    b.HasIndex("AppUserId");

                    b.ToTable("EmpOpps");
                });

            modelBuilder.Entity("API.Entities.HsPrep", b =>
                {
                    b.Property<int>("HsPrepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClassYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColUserId")
                        .HasColumnType("int");

                    b.Property<string>("DreamJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtrCurricular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GradDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HsLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProposedMajor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HsPrepId");

                    b.HasIndex("ColUserId");

                    b.ToTable("HsPreps");
                });

            modelBuilder.Entity("API.Entities.Major", b =>
                {
                    b.Property<int>("MajorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MajorCatId")
                        .HasColumnType("int");

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("MajorId");

                    b.HasIndex("MajorCatId");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("API.Entities.MajorCat", b =>
                {
                    b.Property<int>("MajorCatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MajorCatName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("MajorCatId");

                    b.ToTable("MajorCats");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainHr")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainLogo")
                        .HasColumnType("bit");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("API.Entities.ColPhoto", b =>
                {
                    b.HasOne("API.Entities.ColUser", "ColUser")
                        .WithMany("ColPhotos")
                        .HasForeignKey("ColUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColUser");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.HasOne("API.Entities.ColUser", "ColUser")
                        .WithMany("Colleges")
                        .HasForeignKey("ColUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColUser");
                });

            modelBuilder.Entity("API.Entities.CollegeMajor", b =>
                {
                    b.HasOne("API.Entities.College", "College")
                        .WithMany("CollegeMajors")
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Major", "Major")
                        .WithMany("CollegeMajors")
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("College");

                    b.Navigation("Major");
                });

            modelBuilder.Entity("API.Entities.CollegePrep", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("CollegePreps")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.EmpOpp", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("EmpOpps")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.HsPrep", b =>
                {
                    b.HasOne("API.Entities.ColUser", "ColUser")
                        .WithMany("HsPreps")
                        .HasForeignKey("ColUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColUser");
                });

            modelBuilder.Entity("API.Entities.Major", b =>
                {
                    b.HasOne("API.Entities.MajorCat", "MajorCat")
                        .WithMany("Majors")
                        .HasForeignKey("MajorCatId");

                    b.Navigation("MajorCat");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("CollegePreps");

                    b.Navigation("EmpOpps");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("API.Entities.ColUser", b =>
                {
                    b.Navigation("Colleges");

                    b.Navigation("ColPhotos");

                    b.Navigation("HsPreps");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.Navigation("CollegeMajors");
                });

            modelBuilder.Entity("API.Entities.Major", b =>
                {
                    b.Navigation("CollegeMajors");
                });

            modelBuilder.Entity("API.Entities.MajorCat", b =>
                {
                    b.Navigation("Majors");
                });
#pragma warning restore 612, 618
        }
    }
}