using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheLoop.Data.Migrations
{
    public partial class AddFriendsAssociation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FriendsAssociation",
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
                    table.PrimaryKey("PK_FriendsAssociation", x => x.FriendsAssociationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendsAssociation");
        }
    }
}
