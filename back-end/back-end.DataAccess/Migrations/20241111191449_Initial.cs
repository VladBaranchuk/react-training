using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace back_end.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Fat = table.Column<double>(type: "float", nullable: false),
                    Carbohydrate = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fatigue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatigue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    StartDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sleepy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleepy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EarlyWeight = table.Column<double>(type: "float", nullable: false),
                    StartSleep = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishSleep = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fatigue = table.Column<int>(type: "int", nullable: false),
                    Sleepy = table.Column<int>(type: "int", nullable: false),
                    Mood = table.Column<int>(type: "int", nullable: false),
                    DoDrink = table.Column<bool>(type: "bit", nullable: false),
                    DoSmoke = table.Column<bool>(type: "bit", nullable: false),
                    DoMorningExamples = table.Column<bool>(type: "bit", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Consumption = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayDish",
                columns: table => new
                {
                    DaysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayDish", x => new { x.DaysId, x.DishesId });
                    table.ForeignKey(
                        name: "FK_DayDish_Days_DaysId",
                        column: x => x.DaysId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayDish_Dishes_DishesId",
                        column: x => x.DishesId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fatigue",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "You are completely awake, alert, and feel no signs of fatigue.\r\n                        You are well-rested and have high mental and physical energy.", "Fully alert, wide awake" },
                    { 2, "You are mostly awake but might feel slightly tired or fatigued.\r\n                        Your alertness is generally good, but you may notice a minor decrease \r\n                        in energy compared to being fully alert.", "Very lively, responsivem but not at peak" },
                    { 3, "You are more awake than asleep, but do feel some fatigue. You\r\n                        might be experiencing some difficultly in maintaining peak alterness\r\n                        and your energy levels are decreasing.", "Okay, somewhat fresh" },
                    { 4, "You are equally awake and asleep, indicating moderate fatigue.\r\n                        You might find it challenging to stay fully alert and drowsiness is\r\n                        becoming more apparent.", "A little tired, less than fresh" },
                    { 5, "you are more asleep than awake and significant fatigue is setting in.\r\n                        Your ability to stay alert and focussed is compromised and you may struggle\r\n                        to remain awake.", "Moderately tired, let down" },
                    { 6, "You are mostly alseep but can still be awakened with relative ease.\r\n                        Extreme fatigue has taken over and is is becoming increasingly challenging\r\n                        to stay awake and alert.", "Extremely tired, very difficult to concentrate" },
                    { 7, "You are completely asleep and difficult to awaken. This is the\r\n                        highest level of fatigue. You are in a deep sleep and are not fit for tasks\r\n                        requiring wakefulness.", "Completely exhausted, unable to function effectively" }
                });

            migrationBuilder.InsertData(
                table: "Mood",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "At this highest stage, you fell extremely happy and excited.\r\n                        Your energy levels are high, and you might feel a strong sense of enthusiasm\r\n                        and optimism.", "Elated" },
                    { 2, "You feel positive and content. You might find joy in everyday\r\n                        activities and feel generally satisfied with life.", "Happy" },
                    { 3, "You feel neither particularly happy or sad. Your mood is stable,\r\n                        and you can go about your day without strong emotional swings.", "Neutral" },
                    { 4, "You feel down or unhappy, but not as intensely as in a depressed state.\r\n                        This mood can be triggered by specific events or situations.", "Sad" },
                    { 5, "At this stage, you might feel very low, sad, or hopeless.\r\n                        It can be difficult to find motivation or joy in daily activities.", "Depressed" }
                });

            migrationBuilder.InsertData(
                table: "Sleepy",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "You feel fully awake, alert, and energetic. Your mind is clear,\r\n                        and you are ready to take on the day with a positive attitude.", "Cheerful and rested" },
                    { 2, "you are awake and can perform daily activities, but you feel\r\n                        a persistent sense of tiredness. You might need a coffe or a short nap to\r\n                        boost your energy.", "Awake but tired" },
                    { 3, "You feel a strong urge to sleep, but you can still function.\r\n                        Your reactions are slower, and you might feel a bit foggy or sluggish.", "Drowsy" },
                    { 4, "You are struggling to stay awake, and your body feels heavy.\r\n                        You might experience frequent yawning and have difficulty focusing on tasks.", "Very sleppy" },
                    { 5, "At this level, you feel completely drained and can barely keep\r\n                        your eyes open. Concentration is nearly impossible. and you might find\r\n                        yourself nodding off frequently.", "Completely exhausted" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DayId",
                table: "Activities",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_DayDish_DishesId",
                table: "DayDish",
                column: "DishesId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_ProfileId",
                table: "Days",
                column: "ProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "DayDish");

            migrationBuilder.DropTable(
                name: "Fatigue");

            migrationBuilder.DropTable(
                name: "Mood");

            migrationBuilder.DropTable(
                name: "Sleepy");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
