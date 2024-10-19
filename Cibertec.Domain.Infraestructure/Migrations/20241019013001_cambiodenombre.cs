using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cibertec.Domain.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class cambiodenombre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "TablaCustomers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TablaCustomers",
                table: "TablaCustomers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TablaCustomers",
                table: "TablaCustomers");

            migrationBuilder.RenameTable(
                name: "TablaCustomers",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");
        }
    }
}
