using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Streamer",
                columns: table => new
                {
                    StreamerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    MainGame = table.Column<string>(nullable: true),
                    VOD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streamer", x => x.StreamerId);
                });

            migrationBuilder.CreateTable(
                name: "VideoGame",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    AvgCompletionTime = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    AvgRating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGame", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "VideoGameStreamer",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    StreamerId = table.Column<int>(nullable: false),
                    VideoGameGameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameStreamer", x => new { x.GameId, x.StreamerId });
                    table.ForeignKey(
                        name: "FK_VideoGameStreamer_Streamer_StreamerId",
                        column: x => x.StreamerId,
                        principalTable: "Streamer",
                        principalColumn: "StreamerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoGameStreamer_VideoGame_VideoGameGameId",
                        column: x => x.VideoGameGameId,
                        principalTable: "VideoGame",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameStreamer_StreamerId",
                table: "VideoGameStreamer",
                column: "StreamerId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameStreamer_VideoGameGameId",
                table: "VideoGameStreamer",
                column: "VideoGameGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGameStreamer");

            migrationBuilder.DropTable(
                name: "Streamer");

            migrationBuilder.DropTable(
                name: "VideoGame");
        }
    }
}
