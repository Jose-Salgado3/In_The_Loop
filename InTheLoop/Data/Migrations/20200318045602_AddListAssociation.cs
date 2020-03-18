using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheLoop.Data.Migrations
{
    public partial class AddListAssociation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListAssociations",
                columns: table => new
                {
                    ListAssociationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ListAssociationStatus = table.Column<byte>(nullable: false),
                    ListAssociationActionStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListAssociations", x => x.ListAssociationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListAssociations");
        }
    }
}
