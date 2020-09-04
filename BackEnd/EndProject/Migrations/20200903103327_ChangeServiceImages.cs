using Microsoft.EntityFrameworkCore.Migrations;

namespace EndProject.Migrations
{
    public partial class ChangeServiceImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceImages_Services_ServiceId",
                table: "ServiceImages");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "ServiceImages",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceImages_Services_ServiceId",
                table: "ServiceImages",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceImages_Services_ServiceId",
                table: "ServiceImages");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "ServiceImages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceImages_Services_ServiceId",
                table: "ServiceImages",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
