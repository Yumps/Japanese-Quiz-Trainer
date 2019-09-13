using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manabu.Migrations
{
    public partial class modeledits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "AnswerKeys",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuizQuestionsViewModelId",
                table: "AnswerKeys",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "QuizQuestionsViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestionsViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizQuestionsViewModel_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6245ca78-47a1-4654-b60c-fc67ee618212", "AQAAAAEAACcQAAAAECKD4DgOGCtqVz3ws/8vcgw0sfdGtnqo3T89o2yK17RBaF6tBGASc3tBFDoH/icWSg==" });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerKeys_QuizId",
                table: "AnswerKeys",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerKeys_QuizQuestionsViewModelId",
                table: "AnswerKeys",
                column: "QuizQuestionsViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestionsViewModel_QuestionId",
                table: "QuizQuestionsViewModel",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerKeys_Quizzes_QuizId",
                table: "AnswerKeys",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerKeys_QuizQuestionsViewModel_QuizQuestionsViewModelId",
                table: "AnswerKeys",
                column: "QuizQuestionsViewModelId",
                principalTable: "QuizQuestionsViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerKeys_Quizzes_QuizId",
                table: "AnswerKeys");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerKeys_QuizQuestionsViewModel_QuizQuestionsViewModelId",
                table: "AnswerKeys");

            migrationBuilder.DropTable(
                name: "QuizQuestionsViewModel");

            migrationBuilder.DropIndex(
                name: "IX_AnswerKeys_QuizId",
                table: "AnswerKeys");

            migrationBuilder.DropIndex(
                name: "IX_AnswerKeys_QuizQuestionsViewModelId",
                table: "AnswerKeys");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "AnswerKeys");

            migrationBuilder.DropColumn(
                name: "QuizQuestionsViewModelId",
                table: "AnswerKeys");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d8f6556-7a1b-4877-b925-a173d71e3384", "AQAAAAEAACcQAAAAEFr25by6rtt/ukIVCiDnzmWWqZZP8QfJN7zdMtfVvn252bpEglJ0xgcLjd51WHxIAA==" });
        }
    }
}
