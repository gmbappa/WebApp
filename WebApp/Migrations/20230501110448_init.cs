using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    About = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    FacebookLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LinkedInLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TwitterLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(1024)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(1024)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ip = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PlatformName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PlatformType = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    PlatformVersion = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    BrowserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BrowserVersion = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogSubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogSubCategory_BlogCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "BlogCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutClient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutClient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutClient_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutDescription_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    WebUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutProject_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutService_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutSkill_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeCertification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AuthorityName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AuthorityLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LicenseNo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeCertification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeCertification_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeEducation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    InstituitionName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    InstituitionLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: true),
                    Activities = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeEducation_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeFile_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeTestimony",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeTestimony", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeTestimony_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeTraining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AuthorityName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AuthorityLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeTraining", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeTraining_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CompanyLink = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeWork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeWork_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(1024)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevokedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByIpAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ModifiedByIpAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    RevokedByIpAddress = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsCommentPossible = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPost_BlogCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "BlogCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogPost_BlogSubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "BlogSubCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogPost_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    NodeDepth = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPostComment_BlogPost_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPostDetail_BlogPost_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutClient_ProfileId",
                table: "AboutClient",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutDescription_ProfileId",
                table: "AboutDescription",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutProject_ProfileId",
                table: "AboutProject",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutService_ProfileId",
                table: "AboutService",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSkill_ProfileId",
                table: "AboutSkill",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_CategoryId",
                table: "BlogPost",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_ProfileId",
                table: "BlogPost",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_SubCategoryId",
                table: "BlogPost",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComment_PostId",
                table: "BlogPostComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetail_PostId",
                table: "BlogPostDetail",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogSubCategory_CategoryId",
                table: "BlogSubCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCertification_ProfileId",
                table: "ResumeCertification",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeEducation_ProfileId",
                table: "ResumeEducation",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeFile_ProfileId",
                table: "ResumeFile",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeTestimony_ProfileId",
                table: "ResumeTestimony",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeTraining_ProfileId",
                table: "ResumeTraining",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeWork_ProfileId",
                table: "ResumeWork",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_UserId",
                table: "UserToken",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutClient");

            migrationBuilder.DropTable(
                name: "AboutDescription");

            migrationBuilder.DropTable(
                name: "AboutProject");

            migrationBuilder.DropTable(
                name: "AboutService");

            migrationBuilder.DropTable(
                name: "AboutSkill");

            migrationBuilder.DropTable(
                name: "BlogPostComment");

            migrationBuilder.DropTable(
                name: "BlogPostDetail");

            migrationBuilder.DropTable(
                name: "ResumeCertification");

            migrationBuilder.DropTable(
                name: "ResumeEducation");

            migrationBuilder.DropTable(
                name: "ResumeFile");

            migrationBuilder.DropTable(
                name: "ResumeTestimony");

            migrationBuilder.DropTable(
                name: "ResumeTraining");

            migrationBuilder.DropTable(
                name: "ResumeWork");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "BlogSubCategory");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "BlogCategory");
        }
    }
}
