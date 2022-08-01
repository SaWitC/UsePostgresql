using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RepoPostgrSQL.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(nullable: true),
                    isused = table.Column<bool>(nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false),
                    cost = table.Column<double>(nullable: false),
                    CostDetails = table.Column<float>(nullable: false),
                    ForByte = table.Column<byte>(nullable: false),
                    symbol = table.Column<char>(nullable: false),
                    longtype = table.Column<long>(nullable: false),
                    ulongtype = table.Column<decimal>(nullable: false),
                    uinttype = table.Column<long>(nullable: false),
                    decimalType = table.Column<decimal>(nullable: false),
                    arr = table.Column<int[]>(nullable: true),
                    arr3 = table.Column<double[,]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
