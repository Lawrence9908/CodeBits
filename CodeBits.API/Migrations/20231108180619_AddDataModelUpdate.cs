using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeBits.API.Migrations
{
    public partial class AddDataModelUpdate : Migration   
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84935ABF-D8D6-4704-8AA7-78FCD827BE8D",
                column: "ConcurrencyStamp",
                value: "d6279c67-8e92-433c-a288-cb19d9bb195c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BC0BDDCB-5934-4737-ADD3-FD0CC3799CAB",
                column: "ConcurrencyStamp",
                value: "da7281aa-b970-4cfb-9d3e-224ddb4b04a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "FF0A935F-E2AE-4BF7-94DC-A877E4C835C2",
                column: "ConcurrencyStamp",
                value: "f70a896d-9857-44b0-90ff-0557c8315876");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84935ABF-D8D6-4704-8AA7-78FCD827BE8D",
                column: "ConcurrencyStamp",
                value: "cf07a9d1-3ef3-45ac-a91d-763f54491f87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "BC0BDDCB-5934-4737-ADD3-FD0CC3799CAB",
                column: "ConcurrencyStamp",
                value: "93f8e8ba-89e6-4902-a450-d2611774b36f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "FF0A935F-E2AE-4BF7-94DC-A877E4C835C2",
                column: "ConcurrencyStamp",
                value: "4f2c0b73-475c-4c03-afde-656e50de8c6a");
        }
    }
}
