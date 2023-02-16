using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodesWeaverNew.Migrations
{
    public partial class Abouts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discription = table.Column<string>(nullable: true),
                    Boolet1Title = table.Column<string>(nullable: true),
                    Boolet1TitleDescription = table.Column<string>(nullable: true),
                    Boolet2Title = table.Column<string>(nullable: true),
                    Boolet2TitleDescription = table.Column<string>(nullable: true),
                    Boolet3Title = table.Column<string>(nullable: true),
                    Boolet3TitleDescription = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    willshown = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");
        }
    }
}
