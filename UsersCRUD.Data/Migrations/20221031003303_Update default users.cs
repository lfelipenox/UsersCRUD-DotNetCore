using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersCRUD.Data.Migrations
{
    public partial class Updatedefaultusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("682cf4a8-396f-4c1b-a79d-86b4263b252e"),
                column: "DateCreated",
                value: new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("682cf4a8-396f-4c1b-a79d-86b4263b252e"),
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
