using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class updateDBDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoaiSanPham",
                table: "BaiDang_MeVaBe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DienThoaiDongMay",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LaptopDongMay",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MayTinhBangDongMay",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MayTinhBangHang",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MayTinhBangKichCoManHinh",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MayTinhDeBanMienPhi",
                table: "BaiDang_DoDienTu",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThietBiDongMay",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TiviHang",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoaiSanPham",
                table: "BaiDang_MeVaBe");

            migrationBuilder.DropColumn(
                name: "DienThoaiDongMay",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "LaptopDongMay",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "MayTinhBangDongMay",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "MayTinhBangHang",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "MayTinhBangKichCoManHinh",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "MayTinhDeBanMienPhi",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "ThietBiDongMay",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "TiviHang",
                table: "BaiDang_DoDienTu");
        }
    }
}
