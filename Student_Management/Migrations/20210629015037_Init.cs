using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Management.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course_Details",
                columns: table => new
                {
                    course_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Details", x => x.course_ID);
                });

            migrationBuilder.CreateTable(
                name: "Student_Details",
                columns: table => new
                {
                    student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Details", x => x.student_ID);
                });

            migrationBuilder.CreateTable(
                name: "Tutor_Details",
                columns: table => new
                {
                    tutor_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tutor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tutor_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tutor_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tutor_Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor_Details", x => x.tutor_ID);
                });

            migrationBuilder.CreateTable(
                name: "Student_Enrollment",
                columns: table => new
                {
                    student_Enrollment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_ID = table.Column<int>(type: "int", nullable: false),
                    Student_Detailsstudent_ID = table.Column<int>(type: "int", nullable: true),
                    tutor_ID = table.Column<int>(type: "int", nullable: false),
                    Tutor_Detailstutor_ID = table.Column<int>(type: "int", nullable: true),
                    course_ID = table.Column<int>(type: "int", nullable: false),
                    Course_Detailscourse_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Enrollment", x => x.student_Enrollment_ID);
                    table.ForeignKey(
                        name: "FK_Student_Enrollment_Course_Details_Course_Detailscourse_ID",
                        column: x => x.Course_Detailscourse_ID,
                        principalTable: "Course_Details",
                        principalColumn: "course_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Enrollment_Student_Details_Student_Detailsstudent_ID",
                        column: x => x.Student_Detailsstudent_ID,
                        principalTable: "Student_Details",
                        principalColumn: "student_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Enrollment_Tutor_Details_Tutor_Detailstutor_ID",
                        column: x => x.Tutor_Detailstutor_ID,
                        principalTable: "Tutor_Details",
                        principalColumn: "tutor_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Enrollment_Course_Detailscourse_ID",
                table: "Student_Enrollment",
                column: "Course_Detailscourse_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Enrollment_Student_Detailsstudent_ID",
                table: "Student_Enrollment",
                column: "Student_Detailsstudent_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Enrollment_Tutor_Detailstutor_ID",
                table: "Student_Enrollment",
                column: "Tutor_Detailstutor_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_Enrollment");

            migrationBuilder.DropTable(
                name: "Course_Details");

            migrationBuilder.DropTable(
                name: "Student_Details");

            migrationBuilder.DropTable(
                name: "Tutor_Details");
        }
    }
}
