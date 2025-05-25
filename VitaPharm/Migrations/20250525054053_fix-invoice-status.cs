using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitaPharm.Migrations
{
    /// <inheritdoc />
    public partial class fixinvoicestatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceStatus",
                table: "InvoiceDetails");

            migrationBuilder.AddColumn<string>(
                name: "InvoiceStatus",
                table: "Invoices",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceStatus",
                table: "Invoices");

            migrationBuilder.AddColumn<string>(
                name: "InvoiceStatus",
                table: "InvoiceDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
