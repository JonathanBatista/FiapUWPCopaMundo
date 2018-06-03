using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fiap.CopaMundo.EntityFramework.Migrations
{
    public partial class PosicaoFavorita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PosicaoFavorita",
                table: "Jogador",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosicaoFavorita",
                table: "Jogador");
        }
    }
}
