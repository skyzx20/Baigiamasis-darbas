using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fantazijos_lyga.Migrations
{
    public partial class initialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Komandos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Pavadinimas = table.Column<string>(type: "longtext", nullable: true),
                    ShortName = table.Column<string>(type: "longtext", nullable: true),
                    Logo = table.Column<string>(type: "longtext", nullable: true),
                    Region = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komandos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Pavadinimas = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rungtynes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HomeTeamID = table.Column<int>(type: "int", nullable: false),
                    AwayTeamID = table.Column<int>(type: "int", nullable: false),
                    HomeTeamScore = table.Column<int>(type: "int", nullable: false),
                    AwayTeamScore = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rungtynes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rungtynes_Komandos_AwayTeamID",
                        column: x => x.AwayTeamID,
                        principalTable: "Komandos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rungtynes_Komandos_HomeTeamID",
                        column: x => x.HomeTeamID,
                        principalTable: "Komandos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zaidejai",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Vardas = table.Column<string>(type: "longtext", nullable: true),
                    Kaina = table.Column<double>(type: "double", nullable: false),
                    FotoPath = table.Column<string>(type: "longtext", nullable: true),
                    TotalPoints = table.Column<int>(type: "int", nullable: false),
                    TotalRebounds = table.Column<int>(type: "int", nullable: false),
                    TotalAssist = table.Column<int>(type: "int", nullable: false),
                    TotalBlocks = table.Column<int>(type: "int", nullable: false),
                    TotalTurnovers = table.Column<int>(type: "int", nullable: false),
                    TotalPersonalFouls = table.Column<int>(type: "int", nullable: false),
                    GamesPlayer = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    KomandaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaidejai", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zaidejai_Komandos_KomandaID",
                        column: x => x.KomandaID,
                        principalTable: "Komandos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: true),
                    Password = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RungtyniuStatistikos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MIN = table.Column<string>(type: "longtext", nullable: true),
                    PTS = table.Column<double>(type: "double", nullable: false),
                    REB = table.Column<int>(type: "int", nullable: false),
                    AST = table.Column<int>(type: "int", nullable: false),
                    TOV = table.Column<int>(type: "int", nullable: false),
                    BLK = table.Column<int>(type: "int", nullable: false),
                    PF = table.Column<int>(type: "int", nullable: false),
                    GautuTaskuKiekis = table.Column<double>(type: "double", nullable: false),
                    ZaidejasID = table.Column<int>(type: "int", nullable: false),
                    RungtynesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RungtyniuStatistikos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RungtyniuStatistikos_Rungtynes_RungtynesID",
                        column: x => x.RungtynesID,
                        principalTable: "Rungtynes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RungtyniuStatistikos_Zaidejai_ZaidejasID",
                        column: x => x.ZaidejasID,
                        principalTable: "Zaidejai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NaudotojoPicks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalPoints = table.Column<double>(type: "double", nullable: false),
                    ZaidejasPirmasID = table.Column<int>(type: "int", nullable: false),
                    ZaidejasAntrasID = table.Column<int>(type: "int", nullable: false),
                    ZaidejasTreciasID = table.Column<int>(type: "int", nullable: false),
                    ZaidejasKetvirtasID = table.Column<int>(type: "int", nullable: false),
                    ZaidejasPenktasID = table.Column<int>(type: "int", nullable: false),
                    likoPinigu = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RungtynesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaudotojoPicks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NaudotojoPicks_Rungtynes_RungtynesID",
                        column: x => x.RungtynesID,
                        principalTable: "Rungtynes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaudotojoPicks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaudotojoPicks_Zaidejai_ZaidejasAntrasID",
                        column: x => x.ZaidejasAntrasID,
                        principalTable: "Zaidejai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaudotojoPicks_Zaidejai_ZaidejasKetvirtasID",
                        column: x => x.ZaidejasKetvirtasID,
                        principalTable: "Zaidejai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaudotojoPicks_Zaidejai_ZaidejasPenktasID",
                        column: x => x.ZaidejasPenktasID,
                        principalTable: "Zaidejai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaudotojoPicks_Zaidejai_ZaidejasPirmasID",
                        column: x => x.ZaidejasPirmasID,
                        principalTable: "Zaidejai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaudotojoPicks_Zaidejai_ZaidejasTreciasID",
                        column: x => x.ZaidejasTreciasID,
                        principalTable: "Zaidejai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Komandos",
                columns: new[] { "ID", "Logo", "Pavadinimas", "Region", "ShortName" },
                values: new object[,]
                {
                    { 1, "https://cdn.nba.com/logos/nba/1610612738/global/L/logo.svg", "Boston Celtics", 1, "BOS" },
                    { 28, "https://cdn.nba.com/logos/nba/1610612763/global/L/logo.svg", "Memphis Grizzlies", 0, "MEM" },
                    { 27, "https://cdn.nba.com/logos/nba/1610612745/global/L/logo.svg", "Houston Rockets", 0, "HOU" },
                    { 26, "https://cdn.nba.com/logos/nba/1610612742/global/L/logo.svg", "Dallas Mavericks", 0, "DAL" },
                    { 25, "https://cdn.nba.com/logos/nba/1610612758/global/L/logo.svg", "Sacramento Kings", 0, "SAC" },
                    { 24, "https://cdn.nba.com/logos/nba/1610612756/global/L/logo.svg", "Phoenix Suns", 0, "PHX" },
                    { 23, "https://cdn.nba.com/logos/nba/1610612747/global/L/logo.svg", "Los Angeles Lakers", 0, "LAL" },
                    { 22, "https://cdn.nba.com/logos/nba/1610612746/global/L/logo.svg", "Los Angeles Clippers", 0, "LAC" },
                    { 21, "https://cdn.nba.com/logos/nba/1610612744/global/L/logo.svg", "Golden State Warriors", 0, "GSW" },
                    { 20, "https://cdn.nba.com/logos/nba/1610612762/global/L/logo.svg", "Utah Jazz", 0, "UTA" },
                    { 19, "https://cdn.nba.com/logos/nba/1610612757/global/L/logo.svg", "Portland Trail Blazers", 0, "POR" },
                    { 18, "https://cdn.nba.com/logos/nba/1610612760/global/L/logo.svg", "Oklahoma City Thunder", 0, "OKC" },
                    { 17, "https://cdn.nba.com/logos/nba/1610612750/global/L/logo.svg", "Minnesota Timberwolves", 0, "MIN" },
                    { 16, "https://cdn.nba.com/logos/nba/1610612743/global/L/logo.svg", "Denver Nuggets", 0, "DEN" },
                    { 15, "https://cdn.nba.com/logos/nba/1610612764/global/L/logo.svg", "Washington Wizards", 1, "WAS" },
                    { 14, "https://cdn.nba.com/logos/nba/1610612753/global/L/logo.svg", "Orlando Magic", 1, "ORL" },
                    { 13, "https://cdn.nba.com/logos/nba/1610612748/global/L/logo.svg", "Miami Heat", 1, "MIA" },
                    { 12, "https://cdn.nba.com/logos/nba/1610612766/global/L/logo.svg", "Charlotte Hornets", 1, "CHA" },
                    { 11, "https://cdn.nba.com/logos/nba/1610612737/global/L/logo.svg", "Atlanta Hawks", 1, "ATL" },
                    { 10, "https://cdn.nba.com/logos/nba/1610612749/global/L/logo.svg", "Milwaukee Bucks", 1, "MIL" },
                    { 9, "https://cdn.nba.com/logos/nba/1610612754/global/L/logo.svg", "Indiana Pacers", 1, "IND" },
                    { 8, "https://cdn.nba.com/logos/nba/1610612765/global/L/logo.svg", "Detroit Pistons", 1, "DET" },
                    { 7, "https://cdn.nba.com/logos/nba/1610612739/global/L/logo.svg", "Cleveland Cavaliers", 1, "CLE" },
                    { 6, "https://cdn.nba.com/logos/nba/1610612741/global/L/logo.svg", "Chicago Bulls", 1, "CHI" },
                    { 5, "https://cdn.nba.com/logos/nba/1610612761/global/L/logo.svg", "Toronto Raptors", 1, "TOR" },
                    { 4, "https://cdn.nba.com/logos/nba/1610612755/global/L/logo.svg", "Philadelphia 76ers", 1, "PHI" },
                    { 3, "https://cdn.nba.com/logos/nba/1610612752/global/L/logo.svg", "New York Knicks", 1, "NYK" },
                    { 2, "https://cdn.nba.com/logos/nba/1610612751/global/L/logo.svg", "Brooklyn Nets", 1, "BKN" },
                    { 29, "https://cdn.nba.com/logos/nba/1610612740/global/L/logo.svg", "New Orleans Pelicans", 0, "NOP" },
                    { 30, "https://cdn.nba.com/logos/nba/1610612759/global/L/logo.svg", "San Antonio Spurs", 0, "SAN" }
                });

            migrationBuilder.InsertData(
                table: "Zaidejai",
                columns: new[] { "ID", "FotoPath", "GamesPlayer", "Kaina", "KomandaID", "Position", "TotalAssist", "TotalBlocks", "TotalPersonalFouls", "TotalPoints", "TotalRebounds", "TotalTurnovers", "Vardas" },
                values: new object[,]
                {
                    { 1, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1628369.png", 1, 2000.0, 1, 1, 1, 1, 1, 1, 1, 1, "Jayson Tatum" },
                    { 91, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629668.png", 1, 2000.0, 6, 0, 1, 1, 1, 1, 1, 1, "Zach Norvell" },
                    { 90, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629690.png", 1, 2000.0, 6, 1, 1, 1, 1, 1, 1, 1, "Adam Mokoka" },
                    { 89, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628374.png", 1, 2000.0, 6, 1, 1, 1, 1, 1, 1, 1, "Lauri Markkanen" },
                    { 88, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203897.png", 1, 2000.0, 6, 0, 1, 1, 1, 1, 1, 1, "Zach LaVine" },
                    { 87, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628436.png", 1, 2000.0, 6, 2, 1, 1, 1, 1, 1, 1, "Luke Kornet" },
                    { 86, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628990.png", 1, 2000.0, 6, 1, 1, 1, 1, 1, 1, 1, "Chandler Hutchison" },
                    { 85, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629655.png", 1, 2000.0, 6, 2, 1, 1, 1, 1, 1, 1, "Daniel Gafford" },
                    { 84, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626245.png", 1, 2000.0, 6, 2, 1, 1, 1, 1, 1, 1, "Cristiano Felício" },
                    { 83, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628976.png", 1, 2000.0, 6, 2, 1, 1, 1, 1, 1, 1, "Wendell Carter Jr." },
                    { 82, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627853.png", 1, 2000.0, 6, 0, 1, 1, 1, 1, 1, 1, "Ryan Arcidiacono" },
                    { 81, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628778.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "Paul Watson" },
                    { 80, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629139.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "Yuta Watanabe" },
                    { 79, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627832.png", 1, 2000.0, 5, 0, 1, 1, 1, 1, 1, 1, "Fred VanVleet" },
                    { 78, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629744.png", 1, 2000.0, 5, 0, 1, 1, 1, 1, 1, 1, "Matt Thomas" },
                    { 77, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627783.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "Pascal Siakam" },
                    { 76, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626181.png", 1, 2000.0, 5, 0, 1, 1, 1, 1, 1, 1, "Norman Powell" },
                    { 75, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627775.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "Patrick McCaw" },
                    { 74, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/200768.png", 1, 2000.0, 5, 0, 1, 1, 1, 1, 1, 1, "Kyle Lowry" },
                    { 73, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203458.png", 1, 2000.0, 5, 2, 1, 1, 1, 1, 1, 1, "Alex Len" },
                    { 72, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626169.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "Stanley Johnson" },
                    { 71, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628993.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "Alize Johnson" },
                    { 70, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627740.png", 1, 2000.0, 5, 2, 1, 1, 1, 1, 1, 1, "Henry Ellenson" },
                    { 69, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629056.png", 1, 2000.0, 5, 0, 1, 1, 1, 1, 1, 1, "Terence Davis" },
                    { 68, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629052.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "Oshae Brissett" },
                    { 67, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628449.png", 1, 2000.0, 5, 2, 1, 1, 1, 1, 1, 1, "Chris Boucher" },
                    { 66, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627761.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "DeAndre' Bembry" },
                    { 65, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203382.png", 1, 2000.0, 5, 2, 1, 1, 1, 1, 1, 1, "Aron Baynes" },
                    { 92, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203490.png", 1, 2000.0, 6, 1, 1, 1, 1, 1, 1, 1, "Otto Porter" },
                    { 64, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628384.png", 1, 2000.0, 5, 1, 1, 1, 1, 1, 1, 1, "OG Anunoby" },
                    { 93, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203107.png", 1, 2000.0, 6, 0, 1, 1, 1, 1, 1, 1, "Tomas Satoransky" },
                    { 95, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627756.png", 1, 2000.0, 6, 1, 1, 1, 1, 1, 1, 1, "Denzel Valentine" },
                    { 122, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203486.png", 1, 2000.0, 8, 2, 1, 1, 1, 1, 1, 1, "Mason Plumlee" },
                    { 121, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626143.png", 1, 2000.0, 8, 2, 1, 1, 1, 1, 1, 1, "Jahlil Okafor" },
                    { 120, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629004.png", 1, 2000.0, 8, 1, 1, 1, 1, 1, 1, 1, "Sviatoslav Mykhailiuk" },
                    { 119, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629058.png", 1, 2000.0, 8, 1, 1, 1, 1, 1, 1, 1, "Dzanan Musa" },
                    { 118, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203585.png", 1, 2000.0, 8, 1, 1, 1, 1, 1, 1, 1, "Rodney McGruder" },
                    { 117, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628367.png", 1, 2000.0, 8, 1, 1, 1, 1, 1, 1, 1, "Josh Jackson" },
                    { 116, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201933.png", 1, 2000.0, 8, 1, 1, 1, 1, 1, 1, 1, "Blake Griffin" },
                    { 115, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203924.png", 1, 2000.0, 8, 1, 1, 1, 1, 1, 1, 1, "Jerami Grant" },
                    { 114, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201961.png", 1, 2000.0, 8, 0, 1, 1, 1, 1, 1, 1, "Wayne Ellington" },
                    { 113, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629635.png", 1, 2000.0, 8, 1, 1, 1, 1, 1, 1, 1, "Sekou Doumbouya" },
                    { 112, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629731.png", 1, 2000.0, 7, 1, 1, 1, 1, 1, 1, 1, "Dean Wade" },
                    { 111, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629012.png", 1, 2000.0, 7, 0, 1, 1, 1, 1, 1, 1, "Collin Sexton" },
                    { 110, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629645.png", 1, 2000.0, 7, 1, 1, 1, 1, 1, 1, 1, "Kevin Porter Jr" },
                    { 109, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626224.png", 1, 2000.0, 7, 1, 1, 1, 1, 1, 1, 1, "Cedi Osman" },
                    { 108, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626204.png", 1, 2000.0, 7, 2, 1, 1, 1, 1, 1, 1, "Larry Nance Jr." },
                    { 107, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629760.png", 1, 2000.0, 7, 0, 1, 1, 1, 1, 1, 1, "Matt Mooney" },
                    { 106, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201580.png", 1, 2000.0, 7, 2, 1, 1, 1, 1, 1, 1, "JaVale McGee" },
                    { 105, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627748.png", 1, 2000.0, 7, 2, 1, 1, 1, 1, 1, 1, "Thon Maker" },
                    { 104, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201567.png", 1, 2000.0, 7, 2, 1, 1, 1, 1, 1, 1, "Kevin Love" },
                    { 103, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629636.png", 1, 2000.0, 7, 0, 1, 1, 1, 1, 1, 1, "Darius Garland" },
                    { 102, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203957.png", 1, 2000.0, 7, 0, 1, 1, 1, 1, 1, 1, "Dante Exum" },
                    { 101, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203083.png", 1, 2000.0, 7, 2, 1, 1, 1, 1, 1, 1, "Andre Drummond" },
                    { 100, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628422.png", 1, 2000.0, 7, 0, 1, 1, 1, 1, 1, 1, "Damyean Dotson" },
                    { 99, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203521.png", 1, 2000.0, 7, 0, 1, 1, 1, 1, 1, 1, "Matthew Dellavedova" },
                    { 98, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629716.png", 1, 2000.0, 7, 2, 1, 1, 1, 1, 1, 1, "Marques Bolden" },
                    { 97, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201152.png", 1, 2000.0, 6, 1, 1, 1, 1, 1, 1, 1, "Thaddeus Young" },
                    { 96, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629632.png", 1, 2000.0, 6, 0, 1, 1, 1, 1, 1, 1, "Coby White" },
                    { 94, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202066.png", 1, 2000.0, 6, 0, 1, 1, 1, 1, 1, 1, "Garrett Temple" },
                    { 63, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629680.png", 1, 2000.0, 4, 0, 1, 1, 1, 1, 1, 1, "Matisse Thybulle" },
                    { 62, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627732.png", 1, 2000.0, 4, 0, 1, 1, 1, 1, 1, 1, "Ben Simmons" },
                    { 61, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203118.png", 1, 2000.0, 4, 1, 1, 1, 1, 1, 1, 1, "Mike Scott" },
                    { 28, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629066.png", 1, 2000.0, 2, 1, 1, 1, 1, 1, 1, 1, "Rodions Kurucs" },
                    { 27, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201599.png", 1, 2000.0, 2, 2, 1, 1, 1, 1, 1, 1, "Deandre Jordan" },
                    { 26, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/204020.png", 1, 2000.0, 2, 0, 1, 1, 1, 1, 1, 1, "Tyler Johnson" },
                    { 25, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202681.png", 1, 2000.0, 2, 0, 1, 1, 1, 1, 1, 1, "Kyrie Irving" },
                    { 24, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203925.png", 1, 2000.0, 2, 1, 1, 1, 1, 1, 1, 1, "Joe Harris" },
                    { 23, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201145.png", 1, 2000.0, 2, 2, 1, 1, 1, 1, 1, 1, "Jeff Green" },
                    { 22, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201142.png", 1, 2000.0, 2, 1, 1, 1, 1, 1, 1, 1, "Kevin Durant" },
                    { 21, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203915.png", 1, 2000.0, 2, 0, 1, 1, 1, 1, 1, 1, "Spencer Dinwiddie" },
                    { 20, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629651.png", 1, 2000.0, 2, 2, 1, 1, 1, 1, 1, 1, "Nicolas Claxton" },
                    { 19, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629185.png", 1, 1.0, 2, 0, 1, 1, 1, 1, 1, 1, "Chris Chiozza" },
                    { 18, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628971.png", 1, 2000.0, 2, 0, 1, 1, 1, 1, 1, 1, "Bruce Brown" },
                    { 17, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628386.png", 1, 2000.0, 2, 2, 1, 1, 1, 1, 1, 1, "Jarrett Allen" },
                    { 16, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629057.png", 1, 2000.0, 1, 2, 1, 1, 1, 1, 1, 1, "Robert Williams" },
                    { 15, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629684.png", 1, 2000.0, 1, 1, 1, 1, 1, 1, 1, 1, "Grant Williams" },
                    { 14, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629682.png", 1, 2000.0, 1, 0, 1, 1, 1, 1, 1, 1, "Tremont Waters" },
                    { 13, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1627759.png", 1, 2000.0, 1, 1, 1, 1, 1, 1, 1, 1, "Jaylen Brown" },
                    { 12, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202689.png", 1, 2000.0, 1, 0, 1, 1, 1, 1, 1, 1, "Kemba Walker" },
                    { 11, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/202684.png", 1, 2000.0, 1, 2, 1, 1, 1, 1, 1, 1, "Tristan Thompson" },
                    { 10, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/201952.png", 1, 2000.0, 1, 2, 1, 1, 1, 1, 1, 1, "Daniel Theis" },
                    { 9, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/201952.png", 1, 2000.0, 1, 0, 1, 1, 1, 1, 1, 1, "Jeff Teague" },
                    { 8, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/203935.png", 1, 2000.0, 1, 0, 1, 1, 1, 1, 1, 1, "Marcus Smart" },
                    { 7, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1628400.png", 1, 2000.0, 1, 1, 1, 1, 1, 1, 1, 1, "Semi Ojeleye" },
                    { 6, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629641.png", 1, 2000.0, 1, 0, 1, 1, 1, 1, 1, 1, "Romeo Langford" },
                    { 5, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1628518.png", 1, 2000.0, 1, 1, 1, 1, 1, 1, 1, 1, "Amile Jefferson" },
                    { 4, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629750.png", 1, 2000.0, 1, 0, 1, 1, 1, 1, 1, 1, "Javonte Green" },
                    { 3, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629605.png", 1, 2000.0, 1, 2, 1, 1, 1, 1, 1, 1, "Tacko Fall" },
                    { 2, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629035.png", 1, 2000.0, 1, 0, 1, 1, 1, 1, 1, 1, "Carsen Edwards" },
                    { 29, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627747.png", 1, 2000.0, 2, 1, 1, 1, 1, 1, 1, 1, "Caris LeVert" },
                    { 30, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627789.png", 1, 2000.0, 2, 1, 1, 1, 1, 1, 1, 1, "Timothe Luwawu-Cabarrot" },
                    { 31, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629725.png", 1, 2000.0, 2, 0, 1, 1, 1, 1, 1, 1, "Jeremiah Martin" },
                    { 32, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627752.png", 1, 2000.0, 2, 1, 1, 1, 1, 1, 1, 1, "Taurean Prince" },
                    { 60, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629738.png", 1, 2000.0, 4, 2, 1, 1, 1, 1, 1, 1, "Vincent Poirier" },
                    { 59, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629003.png", 1, 2000.0, 4, 0, 1, 1, 1, 1, 1, 1, "Shake Milton" },
                    { 58, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627788.png", 1, 2000.0, 4, 0, 1, 1, 1, 1, 1, 1, "Furkan Korkmaz" },
                    { 57, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/2730.png", 1, 2000.0, 4, 2, 1, 1, 1, 1, 1, 1, "Dwight Howard" },
                    { 56, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202699.png", 1, 2000.0, 4, 1, 1, 1, 1, 1, 1, 1, "Tobias Harris" },
                    { 55, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201980.png", 1, 2000.0, 4, 0, 1, 1, 1, 1, 1, 1, "Danny Green" },
                    { 54, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628390.png", 1, 2000.0, 4, 1, 1, 1, 1, 1, 1, 1, "Terrance Ferguson" },
                    { 53, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203954.png", 1, 2000.0, 4, 2, 1, 1, 1, 1, 1, 1, "Joel Embiid" },
                    { 52, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203552.png", 1, 2000.0, 4, 0, 1, 1, 1, 1, 1, 1, "Seth Curry" },
                    { 51, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628396.png", 1, 2000.0, 4, 2, 1, 1, 1, 1, 1, 1, "Tony Bradley" },
                    { 50, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626147.png", 1, 2000.0, 4, 1, 1, 1, 1, 1, 1, 1, "Justin Anderson" },
                    { 49, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628372.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "Dennis Smith Jr." },
                    { 48, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629011.png", 1, 2000.0, 3, 2, 1, 1, 1, 1, 1, 1, "Mitchell Robinson" },
                    { 123, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201565.png", 1, 2000.0, 8, 0, 1, 1, 1, 1, 1, 1, "Derrick Rose" },
                    { 47, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626171.png", 1, 2000.0, 3, 1, 1, 1, 1, 1, 1, 1, "Bobby Portis" },
                    { 45, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203901.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "Elfrid Payton" },
                    { 44, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628373.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "Frank Ntilikina" },
                    { 43, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628995.png", 1, 2000.0, 3, 1, 1, 1, 1, 1, 1, 1, "Kevin Knox" },
                    { 42, "https://images.ctfassets.net/u31h9rzvvynu/2Iui3tdfJSCIAYqIepgtXU/b573f60849734a089fb3c8c81966cc6e/Harper-Jared-Headshot-1920.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "Jared Harper" },
                    { 41, "https://images.ctfassets.net/u31h9rzvvynu/6NIDwBaVvnquGbCgeDgM6Y/28ccceffc392b3b1010fd15f521d4603/Harkless-Maurice-Headshot-1920.png", 1, 2000.0, 3, 1, 1, 1, 1, 1, 1, 1, "Maurice Harkless" },
                    { 40, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201959.png", 1, 2000.0, 3, 2, 1, 1, 1, 1, 1, 1, "Taj Gibson" },
                    { 39, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201961.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "Wayne Ellington" },
                    { 38, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628422.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "Damyean Dotson" },
                    { 37, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203493.png", 1, 2000.0, 3, 1, 1, 1, 1, 1, 1, 1, "Reggie Bullock" },
                    { 36, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629649.png", 1, 2000.0, 3, 1, 1, 1, 1, 1, 1, 1, "Ignas Brazdeikis" },
                    { 35, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629628.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "RJ Barrett" },
                    { 34, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203944.png", 1, 2000.0, 3, 2, 1, 1, 1, 1, 1, 1, "Julius Randle" },
                    { 33, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629013.png", 1, 2000.0, 2, 0, 1, 1, 1, 1, 1, 1, "Landry Shamer" },
                    { 46, "https://images.ctfassets.net/u31h9rzvvynu/3hEYkfFn5gEbJN01WolOVV/800b421b296896b4dd21666d219d9584/Pinson-Theo-Headshot-1920.png", 1, 2000.0, 3, 0, 1, 1, 1, 1, 1, 1, "Theo Pinson" },
                    { 124, "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626153.png", 1, 2000.0, 8, 0, 1, 1, 1, 1, 1, 1, "Delon Wright" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NaudotojoPicks_RungtynesID",
                table: "NaudotojoPicks",
                column: "RungtynesID");

            migrationBuilder.CreateIndex(
                name: "IX_NaudotojoPicks_UserId",
                table: "NaudotojoPicks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NaudotojoPicks_ZaidejasAntrasID",
                table: "NaudotojoPicks",
                column: "ZaidejasAntrasID");

            migrationBuilder.CreateIndex(
                name: "IX_NaudotojoPicks_ZaidejasKetvirtasID",
                table: "NaudotojoPicks",
                column: "ZaidejasKetvirtasID");

            migrationBuilder.CreateIndex(
                name: "IX_NaudotojoPicks_ZaidejasPenktasID",
                table: "NaudotojoPicks",
                column: "ZaidejasPenktasID");

            migrationBuilder.CreateIndex(
                name: "IX_NaudotojoPicks_ZaidejasPirmasID",
                table: "NaudotojoPicks",
                column: "ZaidejasPirmasID");

            migrationBuilder.CreateIndex(
                name: "IX_NaudotojoPicks_ZaidejasTreciasID",
                table: "NaudotojoPicks",
                column: "ZaidejasTreciasID");

            migrationBuilder.CreateIndex(
                name: "IX_Rungtynes_AwayTeamID",
                table: "Rungtynes",
                column: "AwayTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Rungtynes_HomeTeamID",
                table: "Rungtynes",
                column: "HomeTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_RungtyniuStatistikos_RungtynesID",
                table: "RungtyniuStatistikos",
                column: "RungtynesID");

            migrationBuilder.CreateIndex(
                name: "IX_RungtyniuStatistikos_ZaidejasID",
                table: "RungtyniuStatistikos",
                column: "ZaidejasID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaidejai_KomandaID",
                table: "Zaidejai",
                column: "KomandaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NaudotojoPicks");

            migrationBuilder.DropTable(
                name: "RungtyniuStatistikos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Rungtynes");

            migrationBuilder.DropTable(
                name: "Zaidejai");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Komandos");
        }
    }
}
