using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class AddFieldToBaiDangBatDongSan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_BatDongSan",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_DoAnThucPham",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_DoDienTu",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_DoDungVanPhong",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_DoGiaDung",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_GiaiTri",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_MeVaBe",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_ThoiTrang",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_ThuCung",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_TuLanh",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_ViecLam",
                table: "BaiDang");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiDang_BaiDang_XeCo",
                table: "BaiDang");

            migrationBuilder.DropIndex(
                name: "IX_BaiDang_id_BaiDangChiTiet",
                table: "BaiDang");

            migrationBuilder.AddColumn<string>(
                name: "Chim_GioiTinh",
                table: "BaiDang_ThuCung",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cho_KichCo",
                table: "BaiDang_ThuCung",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TinhTrang",
                table: "BaiDang_DoDienTu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CanBan",
                table: "BaiDang_BatDongSan",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CcBanCong",
                table: "BaiDang_BatDongSan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CcGiayToPhapLy",
                table: "BaiDang_BatDongSan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CcHuongCuaChinh",
                table: "BaiDang_BatDongSan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CcTinhTrangNoiThat",
                table: "BaiDang_BatDongSan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SoTienCoc",
                table: "BaiDang_BatDongSan",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chim_GioiTinh",
                table: "BaiDang_ThuCung");

            migrationBuilder.DropColumn(
                name: "Cho_KichCo",
                table: "BaiDang_ThuCung");

            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "BaiDang_DoDienTu");

            migrationBuilder.DropColumn(
                name: "CanBan",
                table: "BaiDang_BatDongSan");

            migrationBuilder.DropColumn(
                name: "CcBanCong",
                table: "BaiDang_BatDongSan");

            migrationBuilder.DropColumn(
                name: "CcGiayToPhapLy",
                table: "BaiDang_BatDongSan");

            migrationBuilder.DropColumn(
                name: "CcHuongCuaChinh",
                table: "BaiDang_BatDongSan");

            migrationBuilder.DropColumn(
                name: "CcTinhTrangNoiThat",
                table: "BaiDang_BatDongSan");

            migrationBuilder.DropColumn(
                name: "SoTienCoc",
                table: "BaiDang_BatDongSan");

            migrationBuilder.CreateIndex(
                name: "IX_BaiDang_id_BaiDangChiTiet",
                table: "BaiDang",
                column: "id_BaiDangChiTiet");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_BatDongSan",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_BatDongSan",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_DoAnThucPham",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_DoAnThucPham",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_DoDienTu",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_DoDienTu",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_DoDungVanPhong",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_DoDungVanPhong",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_DoGiaDung",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_DoGiaDung",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_GiaiTri",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_GiaiTri",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_MeVaBe",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_MeVaBe",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_ThoiTrang",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_ThoiTrang",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_ThuCung",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_ThuCung",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_TuLanh",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_TuLanh",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_ViecLam",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_ViecLam",
                principalColumn: "id_BaiDang");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiDang_BaiDang_XeCo",
                table: "BaiDang",
                column: "id_BaiDangChiTiet",
                principalTable: "BaiDang_XeCo",
                principalColumn: "id_BaiDang");
        }
    }
}
