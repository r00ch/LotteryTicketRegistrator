using Microsoft.EntityFrameworkCore.Migrations;

namespace r00ch.LotteryTicketRegostrator.Repositories.Migrations
{
    public partial class AlterCustomersTablePhoneNumberToNvarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "r00ch",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                schema: "r00ch",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
