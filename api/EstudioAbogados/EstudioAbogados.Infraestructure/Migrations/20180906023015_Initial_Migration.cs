using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EstudioAbogados.Infraestructure.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ABOGADO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    APMATERNO = table.Column<string>(maxLength: 100, nullable: false),
                    APPATERNO = table.Column<string>(maxLength: 100, nullable: false),
                    COD_COLEGIOAB = table.Column<string>(maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreationUserId = table.Column<long>(nullable: false),
                    DeletionDate = table.Column<DateTime>(nullable: true),
                    DeletionUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificacionUserId = table.Column<long>(nullable: true),
                    LastModificationDate = table.Column<DateTime>(nullable: true),
                    NOMBRES = table.Column<string>(maxLength: 500, nullable: false),
                    NRODOCUMENTO = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ABOGADO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ABOGADO");
        }
    }
}
