using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastTech.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Create_PedidoItemCardapio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCardapioId",
                table: "Pedido");

            migrationBuilder.CreateTable(
                name: "PedidoItemCardapio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemCardapioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemCardapioId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PedidoId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Removed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RemovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoItemCardapio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoItemCardapio_ItemCardapio_ItemCardapioId",
                        column: x => x.ItemCardapioId,
                        principalTable: "ItemCardapio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PedidoItemCardapio_ItemCardapio_ItemCardapioId1",
                        column: x => x.ItemCardapioId1,
                        principalTable: "ItemCardapio",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItemCardapio_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItemCardapio_Pedido_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedido",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItemCardapio_ItemCardapioId",
                table: "PedidoItemCardapio",
                column: "ItemCardapioId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItemCardapio_ItemCardapioId1",
                table: "PedidoItemCardapio",
                column: "ItemCardapioId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItemCardapio_PedidoId_ItemCardapioId",
                table: "PedidoItemCardapio",
                columns: new[] { "PedidoId", "ItemCardapioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItemCardapio_PedidoId1",
                table: "PedidoItemCardapio",
                column: "PedidoId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoItemCardapio");

            migrationBuilder.AddColumn<Guid>(
                name: "ItemCardapioId",
                table: "Pedido",
                type: "uniqueidentifier",
                maxLength: 50,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
