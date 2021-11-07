using Microsoft.EntityFrameworkCore.Migrations;

namespace FBTarjeta.Migrations
{
    public partial class v101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroTarjeta",
                table: "TarjetaCredito",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroTarjeta",
                table: "TarjetaCredito");
        }
    }
}
