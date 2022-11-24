using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    lesson_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lesson_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.lesson_ID);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    user_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_Pword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.user_ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacher_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacher_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacher_Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacher_ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Number = table.Column<int>(type: "int", nullable: false),
                    lesson_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.student_ID);
                    table.ForeignKey(
                        name: "FK_Students_Lessons_lesson_ID",
                        column: x => x.lesson_ID,
                        principalTable: "Lessons",
                        principalColumn: "lesson_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentTeacher",
                columns: table => new
                {
                    studentsstudent_ID = table.Column<int>(type: "int", nullable: false),
                    teachersteacher_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeacher", x => new { x.studentsstudent_ID, x.teachersteacher_ID });
                    table.ForeignKey(
                        name: "FK_StudentTeacher_Students_studentsstudent_ID",
                        column: x => x.studentsstudent_ID,
                        principalTable: "Students",
                        principalColumn: "student_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTeacher_Teachers_teachersteacher_ID",
                        column: x => x.teachersteacher_ID,
                        principalTable: "Teachers",
                        principalColumn: "teacher_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_lesson_ID",
                table: "Students",
                column: "lesson_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeacher_teachersteacher_ID",
                table: "StudentTeacher",
                column: "teachersteacher_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "StudentTeacher");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
