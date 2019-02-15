using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    AgencyID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgencyName = table.Column<string>(nullable: true),
                    AgencyAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.AgencyID);
                });

            migrationBuilder.CreateTable(
                name: "FunctionCodes",
                columns: table => new
                {
                    FunctionCodeID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<long>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionCodes", x => x.FunctionCodeID);
                });

            migrationBuilder.CreateTable(
                name: "Usergroups",
                columns: table => new
                {
                    UsergroupID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsergroupName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usergroups", x => x.UsergroupID);
                });

            migrationBuilder.CreateTable(
                name: "UserTeachers",
                columns: table => new
                {
                    TeacherID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TeacherName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    UserGroupId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeachers", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "FunctionUsergroupDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsergroupID = table.Column<long>(nullable: false),
                    FunctionCodeID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionUsergroupDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FunctionUsergroupDetails_FunctionCodes_FunctionCodeID",
                        column: x => x.FunctionCodeID,
                        principalTable: "FunctionCodes",
                        principalColumn: "FunctionCodeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FunctionUsergroupDetails_Usergroups_UsergroupID",
                        column: x => x.UsergroupID,
                        principalTable: "Usergroups",
                        principalColumn: "UsergroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClasses",
                columns: table => new
                {
                    ClassID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgencyID = table.Column<long>(nullable: false),
                    ClassName = table.Column<string>(nullable: true),
                    CreateBy = table.Column<long>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClasses", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_SchoolClasses_Agencies_AgencyID",
                        column: x => x.AgencyID,
                        principalTable: "Agencies",
                        principalColumn: "AgencyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolClasses_UserTeachers_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "UserTeachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentParrents",
                columns: table => new
                {
                    ParrentID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParrentName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    CreateBy = table.Column<long>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentParrents", x => x.ParrentID);
                    table.ForeignKey(
                        name: "FK_StudentParrents_UserTeachers_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "UserTeachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherClassDetails",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherID = table.Column<long>(nullable: true),
                    ClassID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherClassDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeacherClassDetails_SchoolClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "SchoolClasses",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherClassDetails_UserTeachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "UserTeachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tuitions",
                columns: table => new
                {
                    TuitionID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassID = table.Column<long>(nullable: false),
                    TuitionName = table.Column<string>(nullable: true),
                    TuitionValue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuitions", x => x.TuitionID);
                    table.ForeignKey(
                        name: "FK_Tuitions_SchoolClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "SchoolClasses",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParrentID = table.Column<long>(nullable: true),
                    ClassID = table.Column<long>(nullable: true),
                    StudentName = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<long>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_SchoolClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "SchoolClasses",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_UserTeachers_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "UserTeachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_StudentParrents_ParrentID",
                        column: x => x.ParrentID,
                        principalTable: "StudentParrents",
                        principalColumn: "ParrentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentID = table.Column<long>(nullable: false),
                    AttendanceBy = table.Column<long>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_Attendances_UserTeachers_AttendanceBy",
                        column: x => x.AttendanceBy,
                        principalTable: "UserTeachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "AgencyID", "AgencyAddress", "AgencyName" },
                values: new object[,]
                {
                    { 1L, "Hà Nội", "Mầm non đơm hoa CS1" },
                    { 2L, "Hà Nội", "Mầm non đơm hoa CS2" },
                    { 3L, "Hà Nội", "Mầm non đơm hoa CS3" },
                    { 4L, "Hà Nội", "Mầm non đơm hoa CS4" }
                });

            migrationBuilder.InsertData(
                table: "UserTeachers",
                columns: new[] { "TeacherID", "Address", "Password", "PhoneNumber", "Status", "TeacherName", "UserGroupId", "Username" },
                values: new object[,]
                {
                    { 1L, "HN", "21232f297a57a5a743894a0e4a801fc3", "0123", true, "Teacher 1", 1L, "admin" },
                    { 2L, "HN", "e10adc3949ba59abbe56e057f20f883e", "0123", true, "Teacher 1", 1L, "teacher_1" },
                    { 3L, "HN", "e10adc3949ba59abbe56e057f20f883e", "0123", true, "Teacher 1", 1L, "teacher_2" },
                    { 4L, "HN", "e10adc3949ba59abbe56e057f20f883e", "0123", true, "Teacher 1", 1L, "teacher_3" }
                });

            migrationBuilder.InsertData(
                table: "SchoolClasses",
                columns: new[] { "ClassID", "AgencyID", "ClassName", "CreateBy", "CreateDate" },
                values: new object[,]
                {
                    { 1L, 1L, "Lớp 1-2 tuổi", 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 1L, "Lớp 2-3 tuổi", 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, 2L, "Lớp 4-5 tuổi", 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 2L, "Lớp 1-2 tuổi", 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 3L, "Lớp 1-2 tuổi", 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "StudentParrents",
                columns: new[] { "ParrentID", "Address", "CreateBy", "CreateDate", "Gender", "ParrentName", "Phone" },
                values: new object[,]
                {
                    { 1L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Nguyễn Mạnh An", "0358466789" },
                    { 2L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bùi Duy Tùng", "0358466789" },
                    { 3L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Nguyễn Tường Anh", "0358466789" },
                    { 4L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Tô Nguyệt Anh", "0358466789" },
                    { 5L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bùi Minh Đức", "0358466789" },
                    { 6L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lò Thị Anh Minh", "0358466789" },
                    { 7L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Tô Minh Diệu", "0358466789" },
                    { 8L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bùi Anh Mạnh", "0358466789" },
                    { 9L, "Hà Nội", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Tăng Nhật Minh", "0358466789" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "ClassID", "CreateBy", "CreateDate", "DateOfBirth", "Gender", "ParrentID", "PhotoPath", "StartDate", "Status", "StudentName" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Minh Anh" },
                    { 9L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 9L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Mạnh Tường" },
                    { 26L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tạ Bình An" },
                    { 17L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Trịnh Công Sơn" },
                    { 8L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Anh Tùng" },
                    { 34L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Văn An" },
                    { 25L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tạ Quang Thắng" },
                    { 16L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lê Minh Sơn" },
                    { 7L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Minh Đức" },
                    { 33L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Duy Tùng" },
                    { 24L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Minh An" },
                    { 15L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Ngọc Huy" },
                    { 6L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lê Nguyễn Ánh Dương" },
                    { 32L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Bất Thành" },
                    { 23L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tạ Minh Hải" },
                    { 14L, 2L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Trần Quang Huy" },
                    { 5L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Trần Hải Anh" },
                    { 31L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lê Thị Thu" },
                    { 10L, 2L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Mạnh An" },
                    { 19L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Phạm Hùng" },
                    { 28L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Cát Phượng" },
                    { 2L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Mạnh Hải" },
                    { 11L, 2L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lê Minh Ngọc" },
                    { 20L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Trí Kiên" },
                    { 18L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 9L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lê Minh Quang" },
                    { 29L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tô Hải Lâm" },
                    { 12L, 2L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Đào Việt Linh" },
                    { 21L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lê Minh Hải" },
                    { 30L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Mạnh Lâm" },
                    { 4L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tô Minh Nguyệt" },
                    { 13L, 2L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Thái Nhất Linh" },
                    { 22L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Hưng Kiên" },
                    { 3L, 1L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bùi Mạnh Tùng" },
                    { 27L, 3L, 1L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 9L, "/Avarta/boy.png", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lê Minh Hoa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_AttendanceBy",
                table: "Attendances",
                column: "AttendanceBy");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentID",
                table: "Attendances",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionUsergroupDetails_FunctionCodeID",
                table: "FunctionUsergroupDetails",
                column: "FunctionCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionUsergroupDetails_UsergroupID",
                table: "FunctionUsergroupDetails",
                column: "UsergroupID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClasses_AgencyID",
                table: "SchoolClasses",
                column: "AgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClasses_CreateBy",
                table: "SchoolClasses",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_StudentParrents_CreateBy",
                table: "StudentParrents",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CreateBy",
                table: "Students",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParrentID",
                table: "Students",
                column: "ParrentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClassDetails_ClassID",
                table: "TeacherClassDetails",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClassDetails_TeacherID",
                table: "TeacherClassDetails",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Tuitions_ClassID",
                table: "Tuitions",
                column: "ClassID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "FunctionUsergroupDetails");

            migrationBuilder.DropTable(
                name: "TeacherClassDetails");

            migrationBuilder.DropTable(
                name: "Tuitions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "FunctionCodes");

            migrationBuilder.DropTable(
                name: "Usergroups");

            migrationBuilder.DropTable(
                name: "SchoolClasses");

            migrationBuilder.DropTable(
                name: "StudentParrents");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "UserTeachers");
        }
    }
}
