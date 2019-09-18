using Microsoft.EntityFrameworkCore.Migrations;

namespace Manabu.Migrations
{
    public partial class dbquizquestionadditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a862706e-b4fd-47d8-8bc2-66b3d4b7671d", "AQAAAAEAACcQAAAAEEzKN407uDeuH6VgCL4Nk+2r0SxrZUYLq9SMdtXR7CyhbHmubw9BKxO6WQAWyQdPEw==" });

            migrationBuilder.InsertData(
                table: "QuizQuestions",
                columns: new[] { "Id", "QuestionId", "QuizId" },
                values: new object[,]
                {
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Quiz 2" },
                    { 3, "Quiz 3" },
                    { 4, "Quiz 4" },
                    { 5, "Quiz 5" },
                    { 6, "Quiz 6" },
                    { 7, "Quiz 7" }
                });

            migrationBuilder.InsertData(
                table: "QuizQuestions",
                columns: new[] { "Id", "QuestionId", "QuizId" },
                values: new object[,]
                {
                    { 11, 13, 2 },
                    { 43, 54, 5 },
                    { 44, 67, 5 },
                    { 45, 69, 5 },
                    { 46, 50, 5 },
                    { 47, 61, 5 },
                    { 48, 64, 5 },
                    { 49, 12, 5 },
                    { 50, 43, 5 },
                    { 51, 57, 6 },
                    { 52, 59, 6 },
                    { 53, 32, 6 },
                    { 54, 21, 6 },
                    { 55, 60, 6 },
                    { 56, 40, 6 },
                    { 57, 25, 6 },
                    { 58, 23, 6 },
                    { 59, 47, 6 },
                    { 60, 53, 6 },
                    { 61, 24, 7 },
                    { 62, 15, 7 },
                    { 63, 41, 7 },
                    { 64, 66, 7 },
                    { 65, 62, 7 },
                    { 66, 46, 7 },
                    { 67, 42, 7 },
                    { 68, 45, 7 },
                    { 69, 18, 7 },
                    { 42, 51, 5 },
                    { 70, 49, 7 },
                    { 41, 38, 5 },
                    { 39, 17, 4 },
                    { 12, 14, 2 },
                    { 13, 16, 2 },
                    { 14, 20, 2 },
                    { 15, 34, 2 },
                    { 16, 35, 2 },
                    { 17, 55, 2 },
                    { 18, 56, 2 },
                    { 19, 63, 2 },
                    { 20, 68, 2 },
                    { 21, 11, 3 },
                    { 22, 29, 3 },
                    { 23, 31, 3 },
                    { 24, 36, 3 },
                    { 25, 37, 3 },
                    { 26, 44, 3 },
                    { 27, 22, 3 },
                    { 28, 28, 3 },
                    { 29, 30, 3 },
                    { 30, 33, 3 },
                    { 31, 39, 4 },
                    { 32, 48, 4 },
                    { 33, 71, 4 },
                    { 34, 26, 4 },
                    { 35, 52, 4 },
                    { 36, 58, 4 },
                    { 37, 65, 4 },
                    { 38, 70, 4 },
                    { 40, 19, 4 },
                    { 71, 27, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8998ceb-3cda-46b5-8b72-c135744d63e3", "AQAAAAEAACcQAAAAENwnNbPv/AMg26WjwWZwQNIu26bHwIhgta+dTfIrZ0C47eE8UIgm0g7fYZHTaTgjKA==" });
        }
    }
}
