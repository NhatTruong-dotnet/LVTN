using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class addMissingFieldIntoBaiDangXeCo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtoDongXe",
                table: "BaiDang_XeCo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhuTungXeMienPhi",
                table: "BaiDang_XeCo",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhuongTienKhacLoaiXeChuyenDung",
                table: "BaiDang_XeCo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhuongTienKhacSoChoXeKhachXeBuyt",
                table: "BaiDang_XeCo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XeDapLoaiXe",
                table: "BaiDang_XeCo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XeMayDongXe",
                table: "BaiDang_XeCo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XeMayLoaiXe",
                table: "BaiDang_XeCo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtoDongXe",
                table: "BaiDang_XeCo");

            migrationBuilder.DropColumn(
                name: "PhuTungXeMienPhi",
                table: "BaiDang_XeCo");

            migrationBuilder.DropColumn(
                name: "PhuongTienKhacLoaiXeChuyenDung",
                table: "BaiDang_XeCo");

            migrationBuilder.DropColumn(
                name: "PhuongTienKhacSoChoXeKhachXeBuyt",
                table: "BaiDang_XeCo");

            migrationBuilder.DropColumn(
                name: "XeDapLoaiXe",
                table: "BaiDang_XeCo");

            migrationBuilder.DropColumn(
                name: "XeMayDongXe",
                table: "BaiDang_XeCo");

            migrationBuilder.DropColumn(
                name: "XeMayLoaiXe",
                table: "BaiDang_XeCo");
        }
    }
}
