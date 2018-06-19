using Microsoft.EntityFrameworkCore.Migrations;

namespace FiouseAPI.Migrations
{
    public partial class FKLengthTypeBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_LengthTypes_LengthTypeId",
                table: "Budgets");

            migrationBuilder.AlterColumn<byte>(
                name: "Id",
                table: "LengthTypes",
                nullable: false,
                oldClrType: typeof(byte))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_LengthType_Budget",
                table: "Budgets",
                column: "LengthTypeId",
                principalTable: "LengthTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LengthType_Budget",
                table: "Budgets");

            migrationBuilder.AlterColumn<byte>(
                name: "Id",
                table: "LengthTypes",
                nullable: false,
                oldClrType: typeof(byte))
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_LengthTypes_LengthTypeId",
                table: "Budgets",
                column: "LengthTypeId",
                principalTable: "LengthTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
