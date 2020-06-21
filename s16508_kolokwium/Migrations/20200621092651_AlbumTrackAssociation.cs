using Microsoft.EntityFrameworkCore.Migrations;

namespace s16508_kolokwium.Migrations
{
    public partial class AlbumTrackAssociation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAlbum",
                table: "Tracks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_IdAlbum",
                table: "Tracks",
                column: "IdAlbum");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_IdAlbum",
                table: "Tracks",
                column: "IdAlbum",
                principalTable: "Albums",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_IdAlbum",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_IdAlbum",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "IdAlbum",
                table: "Tracks");
        }
    }
}
