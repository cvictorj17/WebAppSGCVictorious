using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class CriaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCargo",
                columns: table => new
                {
                    CargoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCargo", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "tbMembro",
                columns: table => new
                {
                    MembroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(type: "varchar(30)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(10)", nullable: true),
                    CNH = table.Column<string>(type: "varchar(20)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    CargoId = table.Column<int>(nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(20)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(200)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(60)", nullable: false),
                    Numero = table.Column<string>(nullable: true),
                    Profissao = table.Column<string>(type: "varchar(30)", nullable: true),
                    UF = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMembro", x => x.MembroId);
                });

            migrationBuilder.CreateTable(
                name: "tbMembroTelefone",
                columns: table => new
                {
                    MembroTelefoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MembroId = table.Column<int>(nullable: false),
                    Numero = table.Column<string>(type: "varchar(20)", nullable: false),
                    TipoTelefone = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMembroTelefone", x => x.MembroTelefoneId);
                    table.ForeignKey(
                        name: "FK_tbMembroTelefone_tbMembro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "tbMembro",
                        principalColumn: "MembroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbMembroTelefone_MembroId",
                table: "tbMembroTelefone",
                column: "MembroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbCargo");

            migrationBuilder.DropTable(
                name: "tbMembroTelefone");

            migrationBuilder.DropTable(
                name: "tbMembro");
        }
    }
}
