using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NagaBugTracking.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bug",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Open = table.Column<bool>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Version = table.Column<float>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    Component = table.Column<string>(nullable: true),
                    Reporter = table.Column<string>(nullable: true),
                    Assignee = table.Column<string>(nullable: true),
                    BugCategory = table.Column<int>(nullable: false),
                    SeverityLevel = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    DateFound = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bug", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bug");
        }
    }
}
