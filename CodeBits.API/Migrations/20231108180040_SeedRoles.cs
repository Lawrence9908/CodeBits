using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeBits.API.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84935ABF-D8D6-4704-8AA7-78FCD827BE8D", "cf07a9d1-3ef3-45ac-a91d-763f54491f87", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "BC0BDDCB-5934-4737-ADD3-FD0CC3799CAB", "93f8e8ba-89e6-4902-a450-d2611774b36f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "FF0A935F-E2AE-4BF7-94DC-A877E4C835C2", "4f2c0b73-475c-4c03-afde-656e50de8c6a", "Writer", "WRITER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84935ABF-D8D6-4704-8AA7-78FCD827BE8D");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BC0BDDCB-5934-4737-ADD3-FD0CC3799CAB");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "FF0A935F-E2AE-4BF7-94DC-A877E4C835C2");
        }
    }
}
