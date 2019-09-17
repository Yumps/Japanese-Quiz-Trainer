using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manabu.Migrations
{
    public partial class dbUserQuizQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerKeyId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserQuestionAnswers_AnswerKeys_AnswerKeyId",
                        column: x => x.AnswerKeyId,
                        principalTable: "AnswerKeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserQuestionAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserQuestionAnswers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8998ceb-3cda-46b5-8b72-c135744d63e3", "AQAAAAEAACcQAAAAENwnNbPv/AMg26WjwWZwQNIu26bHwIhgta+dTfIrZ0C47eE8UIgm0g7fYZHTaTgjKA==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionAnswers_AnswerKeyId",
                table: "UserQuestionAnswers",
                column: "AnswerKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionAnswers_QuestionId",
                table: "UserQuestionAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionAnswers_UserId",
                table: "UserQuestionAnswers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserQuestionAnswers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d8f6556-7a1b-4877-b925-a173d71e3384", "AQAAAAEAACcQAAAAEFr25by6rtt/ukIVCiDnzmWWqZZP8QfJN7zdMtfVvn252bpEglJ0xgcLjd51WHxIAA==" });
        }
    }
}
