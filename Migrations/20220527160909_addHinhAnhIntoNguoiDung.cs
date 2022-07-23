using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class addHinhAnhIntoNguoiDung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NguoiDung_HinhAnh_BaiDang_AnhDaiDienIdHinhAnh",
                table: "NguoiDung");

            migrationBuilder.DropIndex(
                name: "IX_NguoiDung_AnhDaiDienIdHinhAnh",
                table: "NguoiDung");

            migrationBuilder.RenameColumn(
                name: "AnhDaiDienIdHinhAnh",
                table: "NguoiDung",
                newName: "AnhDaiDienID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnhDaiDienID",
                table: "NguoiDung",
                newName: "AnhDaiDienIdHinhAnh");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_AnhDaiDienIdHinhAnh",
                table: "NguoiDung",
                column: "AnhDaiDienIdHinhAnh");

            migrationBuilder.AddForeignKey(
                name: "FK_NguoiDung_HinhAnh_BaiDang_AnhDaiDienIdHinhAnh",
                table: "NguoiDung",
                column: "AnhDaiDienIdHinhAnh",
                principalTable: "HinhAnh_BaiDang",
                principalColumn: "id_HinhAnh",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
