using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class ChaveEstrangeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbMembroTelefone_MembroId",
                table: "tbMembroTelefone",
                column: "MembroId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbMembroTelefone_tbMembro_MembroId",
                table: "tbMembroTelefone",
                column: "MembroId",
                principalTable: "tbMembro",
                principalColumn: "MembroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbMembroTelefone_tbMembro_MembroId",
                table: "tbMembroTelefone");

            migrationBuilder.DropIndex(
                name: "IX_tbMembroTelefone_MembroId",
                table: "tbMembroTelefone");
        }
    }
}
