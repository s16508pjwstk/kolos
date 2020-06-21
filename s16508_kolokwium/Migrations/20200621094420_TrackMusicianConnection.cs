using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace s16508_kolokwium.Migrations
{
    public partial class TrackMusicianConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    IdMusician = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.IdMusician);
                });

            migrationBuilder.CreateTable(
                name: "MusicianTracks",
                columns: table => new
                {
                    IdMusicianTrack = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMusician = table.Column<int>(nullable: true),
                    IdTrack = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianTracks", x => x.IdMusicianTrack);
                    table.ForeignKey(
                        name: "FK_MusicianTracks_Musicians_IdMusician",
                        column: x => x.IdMusician,
                        principalTable: "Musicians",
                        principalColumn: "IdMusician",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MusicianTracks_Tracks_IdTrack",
                        column: x => x.IdTrack,
                        principalTable: "Tracks",
                        principalColumn: "IdTrack",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicianTracks_IdMusician",
                table: "MusicianTracks",
                column: "IdMusician");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianTracks_IdTrack",
                table: "MusicianTracks",
                column: "IdTrack");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianTracks");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
