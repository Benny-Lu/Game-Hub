using Microsoft.EntityFrameworkCore.Migrations;

namespace Game_Hub.Data.Migrations
{
    public partial class GamesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Authorid",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gamesid",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Author",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_Authorid",
                table: "Games",
                column: "Authorid");

            migrationBuilder.CreateIndex(
                name: "IX_Company_Gamesid",
                table: "Company",
                column: "Gamesid");

            migrationBuilder.CreateIndex(
                name: "IX_Author_CompanyID",
                table: "Author",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Company_CompanyID",
                table: "Author",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Games_Gamesid",
                table: "Company",
                column: "Gamesid",
                principalTable: "Games",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Author_Authorid",
                table: "Games",
                column: "Authorid",
                principalTable: "Author",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Company_CompanyID",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Games_Gamesid",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Author_Authorid",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Authorid",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Company_Gamesid",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Author_CompanyID",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "Authorid",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Gamesid",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Author");
        }
    }
}
