using Microsoft.EntityFrameworkCore.Migrations;

namespace FiouseAPI.Migrations
{
    public partial class AutoIncrement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Id",
                table: "LengthTypes",
                nullable: false,
                oldClrType: typeof(byte))
                .Annotation("Sqlite:Autoincrement", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Id",
                table: "LengthTypes",
                nullable: false,
                oldClrType: typeof(byte))
                .OldAnnotation("Sqlite:Autoincrement", true);
        }
    }
}
