using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvoJiuJitsu.Data.Migrations
{
    public partial class initialTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atletas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Idade = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Peso = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Cpf = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Faixa = table.Column<int>(type: "int", nullable: false),
                    CategoriaPorIdade = table.Column<int>(type: "int", nullable: false),
                    CategoriaPeso = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atletas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atletas");
        }
    }
}
