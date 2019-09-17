using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manabu.Migrations
{
    public partial class newmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerId = table.Column<int>(nullable: false),
                    AnswerKeyId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { "54045ffc-d481-4aac-97bb-4e2c5e562c98", "AQAAAAEAACcQAAAAENNu8mW76fqQMtGr+xOp6iJjWl9FNT/nwhoIttvq0Z199maZGZDtatOsbcUbCWJ/1A==" });

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
                values: new object[] { "b032ffe9-9271-49ff-a13e-7328c6c9179d", "AQAAAAEAACcQAAAAEAoN0pocvytsq+AnP5RIjVq0+v0vPisuXvb2sRabeUH09h+CgM2t7PBzr0esjDtp2w==" });
        }
    }
}
