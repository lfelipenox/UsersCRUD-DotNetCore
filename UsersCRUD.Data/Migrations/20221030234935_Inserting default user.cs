using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersCRUD.Data.Migrations
{
    public partial class Insertingdefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("682cf4a8-396f-4c1b-a79d-86b4263b252e"), "userdefault@usercrud.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("682cf4a8-396f-4c1b-a79d-86b4263b252e"));
        }
    }
}
