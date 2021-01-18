using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PedidosGarcomMvc.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopaId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CozinhaId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Copa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mesa = table.Column<int>(nullable: false),
                    Bebida = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cozinha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mesa = table.Column<int>(nullable: false),
                    Prato = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cozinha", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CopaId",
                table: "Pedido",
                column: "CopaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CozinhaId",
                table: "Pedido",
                column: "CozinhaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Copa_CopaId",
                table: "Pedido",
                column: "CopaId",
                principalTable: "Copa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cozinha_CozinhaId",
                table: "Pedido",
                column: "CozinhaId",
                principalTable: "Cozinha",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Copa_CopaId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cozinha_CozinhaId",
                table: "Pedido");

            migrationBuilder.DropTable(
                name: "Copa");

            migrationBuilder.DropTable(
                name: "Cozinha");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CopaId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CozinhaId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "CopaId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "CozinhaId",
                table: "Pedido");
        }
    }
}
