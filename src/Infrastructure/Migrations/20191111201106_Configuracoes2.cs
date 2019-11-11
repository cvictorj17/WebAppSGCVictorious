using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class Configuracoes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "tbMembro",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(3)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "tbMembro",
                type: "char(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
