﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColUsers",
                columns: table => new
                {
                    ColUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColUserName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ColPhone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ColUserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColUsers", x => x.ColUserId);
                });

            migrationBuilder.CreateTable(
                name: "MajorCats",
                columns: table => new
                {
                    MajorCatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorCatName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorCats", x => x.MajorCatId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    CollegeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollegeName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CollegeLocation = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CollegeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.CollegeId);
                    table.ForeignKey(
                        name: "FK_Colleges_ColUsers_ColUserId",
                        column: x => x.ColUserId,
                        principalTable: "ColUsers",
                        principalColumn: "ColUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColPhotos",
                columns: table => new
                {
                    ColPhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColPhotos", x => x.ColPhotoId);
                    table.ForeignKey(
                        name: "FK_ColPhotos_ColUsers_ColUserId",
                        column: x => x.ColUserId,
                        principalTable: "ColUsers",
                        principalColumn: "ColUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HsPreps",
                columns: table => new
                {
                    HsPrepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GPA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposedMajor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtrCurricular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DreamJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HsPreps", x => x.HsPrepId);
                    table.ForeignKey(
                        name: "FK_HsPreps_ColUsers_ColUserId",
                        column: x => x.ColUserId,
                        principalTable: "ColUsers",
                        principalColumn: "ColUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MajorCatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorId);
                    table.ForeignKey(
                        name: "FK_Majors_MajorCats_MajorCatId",
                        column: x => x.MajorCatId,
                        principalTable: "MajorCats",
                        principalColumn: "MajorCatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollegePreps",
                columns: table => new
                {
                    CollegePrepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcademicPlus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPlus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPA = table.Column<float>(type: "real", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DreamJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hometown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegePreps", x => x.CollegePrepId);
                    table.ForeignKey(
                        name: "FK_CollegePreps_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpOpps",
                columns: table => new
                {
                    EmpOppId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToApply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpOpps", x => x.EmpOppId);
                    table.ForeignKey(
                        name: "FK_EmpOpps_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HrUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    IsMainLogo = table.Column<bool>(type: "bit", nullable: false),
                    IsMainHr = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeMajors",
                columns: table => new
                {
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    MajorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeMajors", x => new { x.CollegeId, x.MajorId });
                    table.ForeignKey(
                        name: "FK_CollegeMajors_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "CollegeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeMajors_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "MajorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollegeMajors_MajorId",
                table: "CollegeMajors",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegePreps_AppUserId",
                table: "CollegePreps",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Colleges_ColUserId",
                table: "Colleges",
                column: "ColUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ColPhotos_ColUserId",
                table: "ColPhotos",
                column: "ColUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpOpps_AppUserId",
                table: "EmpOpps",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HsPreps_ColUserId",
                table: "HsPreps",
                column: "ColUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_MajorCatId",
                table: "Majors",
                column: "MajorCatId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeMajors");

            migrationBuilder.DropTable(
                name: "CollegePreps");

            migrationBuilder.DropTable(
                name: "ColPhotos");

            migrationBuilder.DropTable(
                name: "EmpOpps");

            migrationBuilder.DropTable(
                name: "HsPreps");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ColUsers");

            migrationBuilder.DropTable(
                name: "MajorCats");
        }
    }
}
