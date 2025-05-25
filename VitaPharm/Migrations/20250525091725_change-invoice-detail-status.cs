using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitaPharm.Migrations
{
    /// <inheritdoc />
    public partial class changeinvoicedetailstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Commodities_CommodityID",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "InvoiceDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CommodityID",
                table: "InvoiceDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_BatchID",
                table: "InvoiceDetails",
                column: "BatchID");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Batches_BatchID",
                table: "InvoiceDetails",
                column: "BatchID",
                principalTable: "Batches",
                principalColumn: "BatchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Commodities_CommodityID",
                table: "InvoiceDetails",
                column: "CommodityID",
                principalTable: "Commodities",
                principalColumn: "CommodityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Batches_BatchID",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Commodities_CommodityID",
                table: "InvoiceDetails");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceDetails_BatchID",
                table: "InvoiceDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CommodityID",
                table: "InvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "InvoiceDetails",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Commodities_CommodityID",
                table: "InvoiceDetails",
                column: "CommodityID",
                principalTable: "Commodities",
                principalColumn: "CommodityID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
