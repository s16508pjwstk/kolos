using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace s16508_kolokwium.Migrations
{
    public partial class addedMusicLabelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMusicLabel",
                table: "Albums",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MusicLabels",
                columns: table => new
                {
                    IdMusicLabel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicLabels", x => x.IdMusicLabel);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_IdMusicLabel",
                table: "Albums",
                column: "IdMusicLabel");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_MusicLabels_IdMusicLabel",
                table: "Albums",
                column: "IdMusicLabel",
                principalTable: "MusicLabels",
                principalColumn: "IdMusicLabel",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_MusicLabels_IdMusicLabel",
                table: "Albums");

            migrationBuilder.DropTable(
                name: "MusicLabels");

            migrationBuilder.DropIndex(
                name: "IX_Albums_IdMusicLabel",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "IdMusicLabel",
                table: "Albums");
        }
    }
}
