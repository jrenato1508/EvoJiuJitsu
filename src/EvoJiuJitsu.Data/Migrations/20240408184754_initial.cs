using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvoJiuJitsu.Data.Migrations
{
    public partial class initial : Migration
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
                    Telefone = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Faixa = table.Column<int>(type: "int", nullable: false),
                    CategoriaPorIdade = table.Column<int>(type: "int", nullable: false),
                    CategoriaPeso = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Polo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atletas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtletaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logradouro = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Numero = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Complemento = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Cep = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Estado = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Atletas_AtletaId",
                        column: x => x.AtletaId,
                        principalTable: "Atletas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_AtletaId",
                table: "Enderecos",
                column: "AtletaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Atletas");
        }
    }
}
