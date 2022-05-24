using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class addFieldIntoNguoiDung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DanhGiaHeThong",
                table: "NguoiDung",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "NguoiDung",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DanhGiaHeThong",
                table: "NguoiDung");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "NguoiDung");
        }
    }
}
