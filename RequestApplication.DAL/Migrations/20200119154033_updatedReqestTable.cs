using Microsoft.EntityFrameworkCore.Migrations;

namespace RequestApplication.DAL.Migrations
{
    public partial class updatedReqestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReply",
                table: "Requests");

            migrationBuilder.AddColumn<bool>(
                name: "IsPositive",
                table: "Requests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPositive",
                table: "Requests");

            migrationBuilder.AddColumn<bool>(
                name: "IsReply",
                table: "Requests",
                type: "bit",
                nullable: true);
        }
    }
}
