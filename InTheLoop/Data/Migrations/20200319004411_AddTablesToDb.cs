using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheLoop.Data.Migrations
{
    public partial class AddTablesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FriendsAssociations",
                columns: table => new
                {
                    FriendsAssociationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    FriendId = table.Column<int>(nullable: false),
                    FriendsAssociationStatus = table.Column<byte>(nullable: false),
                    FriendsAssociationActionStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendsAssociations", x => x.FriendsAssociationId);
                });

            migrationBuilder.CreateTable(
                name: "ListItems",
                columns: table => new
                {
                    ListItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListId = table.Column<int>(nullable: false),
                    ListItemCreatorId = table.Column<int>(nullable: false),
                    ListItemTitle = table.Column<string>(maxLength: 90, nullable: false),
                    ListItemUrgency = table.Column<int>(nullable: false),
                    ListItemIsChecked = table.Column<bool>(nullable: false),
                    ListItemDescription = table.Column<string>(maxLength: 256, nullable: true),
                    ListItemAddDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItems", x => x.ListItemId);
                });

            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    ListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListCreatorId = table.Column<int>(nullable: false),
                    ListTitle = table.Column<string>(maxLength: 90, nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.ListId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendsAssociations");

            migrationBuilder.DropTable(
                name: "ListItems");

            migrationBuilder.DropTable(
                name: "Lists");
        }
    }
}
