using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class changeDataTypeAnhDaiDienNguoiDung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnhDaiDienID",
                table: "NguoiDung");

            migrationBuilder.AddColumn<string>(
                name: "AnhDaiDienSource",
                table: "NguoiDung",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnhDaiDienSource",
                table: "NguoiDung");

            migrationBuilder.AddColumn<int>(
                name: "AnhDaiDienID",
                table: "NguoiDung",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
