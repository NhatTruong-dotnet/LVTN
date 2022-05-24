﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class addCreatedDateToNguoiDung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "NguoiDung",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "NguoiDung");
        }
    }
}
