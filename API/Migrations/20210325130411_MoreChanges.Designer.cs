﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210325130411_MoreChanges")]
    partial class MoreChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("API.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AppUserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("College")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GradDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hometown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("API.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("API.Entities.ColPhoto", b =>
                {
                    b.Property<int>("ColPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdminUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HsStudentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMainAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainCol")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainHs")
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

                    b.Property<int>("AverageAid")
                        .HasColumnType("int");

                    b.Property<string>("ClassYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColUserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeEnrollment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HsGradDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HsLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NetPay")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("RoomAndBoard")
                        .HasColumnType("int");

                    b.Property<int>("Tuition")
                        .HasColumnType("int");

                    b.HasKey("ColUserId");

                    b.ToTable("ColUsers");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.Property<int>("CollegeId")
                        .HasColumnType("int");

                    b.Property<string>("AdminContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColUserId")
                        .HasColumnType("int");

                    b.Property<string>("CollegeCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegePresident")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeVirtual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeYearFounded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

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

                    b.Property<string>("Arts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Athletics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DreamJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraCurricular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPlus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CollegePrepId");

                    b.HasIndex("AppUserId");

                    b.ToTable("CollegePreps");
                });

            modelBuilder.Entity("API.Entities.Connection", b =>
                {
                    b.Property<string>("ConnectionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConnectionId");

                    b.HasIndex("GroupName");

                    b.ToTable("Connections");
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

                    b.Property<string>("CompanyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowToApply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LookingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpOppId");

                    b.HasIndex("AppUserId");

                    b.ToTable("EmpOpps");
                });

            modelBuilder.Entity("API.Entities.FactFeature", b =>
                {
                    b.Property<int>("FactId")
                        .HasColumnType("int");

                    b.Property<int>("CollegeId")
                        .HasColumnType("int");

                    b.Property<string>("FactBullet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FactId");

                    b.HasIndex("CollegeId");

                    b.ToTable("FactFeatures");
                });

            modelBuilder.Entity("API.Entities.Group", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("API.Entities.HsPrep", b =>
                {
                    b.Property<int>("HsPrepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ColUserId")
                        .HasColumnType("int");

                    b.Property<string>("DreamJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraCurricular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GradDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProposedMajor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HsPrepId");

                    b.HasIndex("ColUserId");

                    b.ToTable("HsPreps");
                });

            modelBuilder.Entity("API.Entities.Major", b =>
                {
                    b.Property<int>("MajorId")
                        .HasColumnType("int");

                    b.Property<int>("MajorCatId")
                        .HasColumnType("int");

                    b.Property<string>("MajorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MajorId");

                    b.HasIndex("MajorCatId");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("API.Entities.MajorCat", b =>
                {
                    b.Property<int>("MajorCatId")
                        .HasColumnType("int");

                    b.Property<string>("MajorCatName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MajorCatId");

                    b.ToTable("MajorCats");
                });

            modelBuilder.Entity("API.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("datetime2");

                    b.Property<string>("RecipientAppUserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipientCollege")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipientCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RecipientFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<string>("RecipientUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderAppUserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderCollege")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("SenderFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("SenderUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
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

            modelBuilder.Entity("API.Entities.UserLike", b =>
                {
                    b.Property<int>("SourceUserId")
                        .HasColumnType("int");

                    b.Property<int>("LikedUserId")
                        .HasColumnType("int");

                    b.HasKey("SourceUserId", "LikedUserId");

                    b.HasIndex("LikedUserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("API.Entities.AppUserRole", b =>
                {
                    b.HasOne("API.Entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
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

            modelBuilder.Entity("API.Entities.Connection", b =>
                {
                    b.HasOne("API.Entities.Group", null)
                        .WithMany("Connections")
                        .HasForeignKey("GroupName");
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

            modelBuilder.Entity("API.Entities.FactFeature", b =>
                {
                    b.HasOne("API.Entities.College", "College")
                        .WithMany("FactFeatures")
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("College");
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
                        .HasForeignKey("MajorCatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MajorCat");
                });

            modelBuilder.Entity("API.Entities.Message", b =>
                {
                    b.HasOne("API.Entities.AppUser", "Recipient")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
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

            modelBuilder.Entity("API.Entities.UserLike", b =>
                {
                    b.HasOne("API.Entities.AppUser", "LikedUser")
                        .WithMany("LikedByUsers")
                        .HasForeignKey("LikedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "SourceUser")
                        .WithMany("LikedUsers")
                        .HasForeignKey("SourceUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("LikedUser");

                    b.Navigation("SourceUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("API.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("CollegePreps");

                    b.Navigation("EmpOpps");

                    b.Navigation("LikedByUsers");

                    b.Navigation("LikedUsers");

                    b.Navigation("MessagesReceived");

                    b.Navigation("MessagesSent");

                    b.Navigation("Photos");

                    b.Navigation("UserRoles");
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

                    b.Navigation("FactFeatures");
                });

            modelBuilder.Entity("API.Entities.Group", b =>
                {
                    b.Navigation("Connections");
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
