using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloWorldJNodz.Migrations
{
    public partial class AddSpeciesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalSpeciesID",
                table: "Animal",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_AnimalSpeciesID",
                table: "Animal",
                column: "AnimalSpeciesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesID",
                table: "Animal",
                column: "AnimalSpeciesID",
                principalTable: "Species",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesID",
                table: "Animal");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Animal_AnimalSpeciesID",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "AnimalSpeciesID",
                table: "Animal");
        }
    }
}
