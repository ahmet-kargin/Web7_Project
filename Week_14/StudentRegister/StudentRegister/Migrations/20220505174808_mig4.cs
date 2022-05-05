using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRegister.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentLessons_Lessons_LessonId",
                table: "StudentLessons");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentLessons_Students_StudentId",
                table: "StudentLessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentLessons",
                table: "StudentLessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "StudentLessons",
                newName: "StudentLesson");

            migrationBuilder.RenameTable(
                name: "Lessons",
                newName: "Lesson");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_StudentLessons_StudentId",
                table: "StudentLesson",
                newName: "IX_StudentLesson_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentLessons_LessonId",
                table: "StudentLesson",
                newName: "IX_StudentLesson_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentLesson",
                table: "StudentLesson",
                column: "StudentLessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson",
                column: "LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLesson_Lesson_LessonId",
                table: "StudentLesson",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLesson_Students_StudentId",
                table: "StudentLesson",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Department_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentLesson_Lesson_LessonId",
                table: "StudentLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentLesson_Students_StudentId",
                table: "StudentLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Department_DepartmentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentLesson",
                table: "StudentLesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "StudentLesson",
                newName: "StudentLessons");

            migrationBuilder.RenameTable(
                name: "Lesson",
                newName: "Lessons");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_StudentLesson_StudentId",
                table: "StudentLessons",
                newName: "IX_StudentLessons_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentLesson_LessonId",
                table: "StudentLessons",
                newName: "IX_StudentLessons_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentLessons",
                table: "StudentLessons",
                column: "StudentLessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                column: "LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLessons_Lessons_LessonId",
                table: "StudentLessons",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLessons_Students_StudentId",
                table: "StudentLessons",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
