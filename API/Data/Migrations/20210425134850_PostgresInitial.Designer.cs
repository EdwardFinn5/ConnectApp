﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210425134850_PostgresInitial")]
    partial class PostgresInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("API.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AcademicPlus")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("AppDeadline")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("AppUserType")
                        .HasColumnType("text");

                    b.Property<string>("ApplyEmail")
                        .HasColumnType("text");

                    b.Property<string>("Arts")
                        .HasColumnType("text");

                    b.Property<string>("Athletics")
                        .HasColumnType("text");

                    b.Property<string>("BestEmail")
                        .HasColumnType("text");

                    b.Property<string>("BestPhone")
                        .HasColumnType("text");

                    b.Property<string>("ClassYear")
                        .HasColumnType("text");

                    b.Property<string>("College")
                        .HasColumnType("text");

                    b.Property<string>("Company")
                        .HasColumnType("text");

                    b.Property<string>("CompanyDescription")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Contact")
                        .HasColumnType("text");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DreamJob")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("ExtraCurricular")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("GPA")
                        .HasColumnType("text");

                    b.Property<DateTime>("GradDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Hometown")
                        .HasColumnType("text");

                    b.Property<string>("HowToApply")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LookingFor")
                        .HasColumnType("text");

                    b.Property<string>("Major")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<string>("PositionDescription")
                        .HasColumnType("text");

                    b.Property<string>("PositionLocation")
                        .HasColumnType("text");

                    b.Property<string>("PositionType")
                        .HasColumnType("text");

                    b.Property<string>("Resume")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("WorkPlus")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("API.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("API.Entities.ColPhoto", b =>
                {
                    b.Property<int>("ColPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AdminUrl")
                        .HasColumnType("text");

                    b.Property<string>("ColUrl")
                        .HasColumnType("text");

                    b.Property<int>("ColUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("HsStudentUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsMainAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMainCol")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMainHs")
                        .HasColumnType("boolean");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.HasKey("ColPhotoId");

                    b.HasIndex("ColUserId");

                    b.ToTable("ColPhotos");
                });

            modelBuilder.Entity("API.Entities.ColUser", b =>
                {
                    b.Property<int>("ColUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("AverageAid")
                        .HasColumnType("integer");

                    b.Property<string>("ClassYear")
                        .HasColumnType("text");

                    b.Property<string>("ColUserName")
                        .HasColumnType("text");

                    b.Property<string>("ColUserType")
                        .HasColumnType("text");

                    b.Property<string>("CollegeEnrollment")
                        .HasColumnType("text");

                    b.Property<string>("CollegeLocation")
                        .HasColumnType("text");

                    b.Property<string>("CollegeName")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<DateTime>("HsGradDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("HsLocation")
                        .HasColumnType("text");

                    b.Property<string>("HsName")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("NetPay")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<int>("RoomAndBoard")
                        .HasColumnType("integer");

                    b.Property<int>("Tuition")
                        .HasColumnType("integer");

                    b.HasKey("ColUserId");

                    b.ToTable("ColUsers");
                });

            modelBuilder.Entity("API.Entities.College", b =>
                {
                    b.Property<int>("CollegeId")
                        .HasColumnType("integer");

                    b.Property<string>("AdminContact")
                        .HasColumnType("text");

                    b.Property<string>("AdminTitle")
                        .HasColumnType("text");

                    b.Property<int>("ColUserId")
                        .HasColumnType("integer");

                    b.Property<string>("CollegeCity")
                        .HasColumnType("text");

                    b.Property<string>("CollegeDescription")
                        .HasColumnType("text");

                    b.Property<string>("CollegeEmail")
                        .HasColumnType("text");

                    b.Property<string>("CollegePhone")
                        .HasColumnType("text");

                    b.Property<string>("CollegePresident")
                        .HasColumnType("text");

                    b.Property<string>("CollegeState")
                        .HasColumnType("text");

                    b.Property<string>("CollegeStreet")
                        .HasColumnType("text");

                    b.Property<string>("CollegeVirtual")
                        .HasColumnType("text");

                    b.Property<string>("CollegeWebsite")
                        .HasColumnType("text");

                    b.Property<string>("CollegeYearFounded")
                        .HasColumnType("text");

                    b.Property<string>("CollegeZip")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.HasKey("CollegeId");

                    b.HasIndex("ColUserId");

                    b.ToTable("Colleges");
                });

            modelBuilder.Entity("API.Entities.CollegeMajor", b =>
                {
                    b.Property<int>("CollegeId")
                        .HasColumnType("integer");

                    b.Property<int>("MajorId")
                        .HasColumnType("integer");

                    b.HasKey("CollegeId", "MajorId");

                    b.HasIndex("MajorId");

                    b.ToTable("CollegeMajors");
                });

            modelBuilder.Entity("API.Entities.Connection", b =>
                {
                    b.Property<string>("ConnectionId")
                        .HasColumnType("text");

                    b.Property<string>("GroupName")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("ConnectionId");

                    b.HasIndex("GroupName");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("API.Entities.FactFeature", b =>
                {
                    b.Property<int>("FactId")
                        .HasColumnType("integer");

                    b.Property<int>("CollegeId")
                        .HasColumnType("integer");

                    b.Property<string>("FactBullet")
                        .HasColumnType("text");

                    b.HasKey("FactId");

                    b.HasIndex("CollegeId");

                    b.ToTable("FactFeatures");
                });

            modelBuilder.Entity("API.Entities.Group", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("API.Entities.HsPrep", b =>
                {
                    b.Property<int>("HsPrepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("ColUserId")
                        .HasColumnType("integer");

                    b.Property<string>("DreamJob")
                        .HasColumnType("text");

                    b.Property<string>("ExtraCurricular")
                        .HasColumnType("text");

                    b.Property<string>("GPA")
                        .HasColumnType("text");

                    b.Property<DateTime>("GradDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("ProposedMajor")
                        .HasColumnType("text");

                    b.HasKey("HsPrepId");

                    b.HasIndex("ColUserId");

                    b.ToTable("HsPreps");
                });

            modelBuilder.Entity("API.Entities.Major", b =>
                {
                    b.Property<int>("MajorId")
                        .HasColumnType("integer");

                    b.Property<int>("MajorCatId")
                        .HasColumnType("integer");

                    b.Property<string>("MajorName")
                        .HasColumnType("text");

                    b.HasKey("MajorId");

                    b.HasIndex("MajorCatId");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("API.Entities.MajorCat", b =>
                {
                    b.Property<int>("MajorCatId")
                        .HasColumnType("integer");

                    b.Property<string>("MajorCatName")
                        .HasColumnType("text");

                    b.HasKey("MajorCatId");

                    b.ToTable("MajorCats");
                });

            modelBuilder.Entity("API.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RecipientAppUserType")
                        .HasColumnType("text");

                    b.Property<string>("RecipientCollege")
                        .HasColumnType("text");

                    b.Property<string>("RecipientCompany")
                        .HasColumnType("text");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("RecipientFirstName")
                        .HasColumnType("text");

                    b.Property<int>("RecipientId")
                        .HasColumnType("integer");

                    b.Property<string>("RecipientUsername")
                        .HasColumnType("text");

                    b.Property<string>("SenderAppUserType")
                        .HasColumnType("text");

                    b.Property<string>("SenderCollege")
                        .HasColumnType("text");

                    b.Property<string>("SenderCompany")
                        .HasColumnType("text");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("SenderFirstName")
                        .HasColumnType("text");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.Property<string>("SenderUsername")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("HrUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsMain")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMainHr")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMainLogo")
                        .HasColumnType("boolean");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<string>("StudentUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("API.Entities.UserLike", b =>
                {
                    b.Property<int>("SourceUserId")
                        .HasColumnType("integer");

                    b.Property<int>("LikedUserId")
                        .HasColumnType("integer");

                    b.HasKey("SourceUserId", "LikedUserId");

                    b.HasIndex("LikedUserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

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

            modelBuilder.Entity("API.Entities.Connection", b =>
                {
                    b.HasOne("API.Entities.Group", null)
                        .WithMany("Connections")
                        .HasForeignKey("GroupName");
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
