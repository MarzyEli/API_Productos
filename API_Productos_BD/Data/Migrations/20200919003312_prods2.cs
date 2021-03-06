﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    public partial class prods2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "cat_categoria",
                schema: "public",
                columns: table => new
                {
                    id_categoria = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(nullable: true),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_categoria", x => x.id_categoria);
                });

            migrationBuilder.CreateTable(
                name: "cat_marca",
                schema: "public",
                columns: table => new
                {
                    id_marca = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(nullable: true),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_marca", x => x.id_marca);
                });

            migrationBuilder.CreateTable(
                name: "cat_proveedor",
                schema: "public",
                columns: table => new
                {
                    id_proveedor = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(nullable: true),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_proveedor", x => x.id_proveedor);
                });

            migrationBuilder.CreateTable(
                name: "cat_unidad_medida",
                schema: "public",
                columns: table => new
                {
                    id_unidad_medida = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(nullable: true),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_unidad_medida", x => x.id_unidad_medida);
                });

            migrationBuilder.CreateTable(
                name: "cat_producto",
                schema: "public",
                columns: table => new
                {
                    id_producto = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sku = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    precio_venta = table.Column<decimal>(nullable: false),
                    costo = table.Column<decimal>(nullable: false),
                    imagen = table.Column<string>(nullable: true),
                    id_proveedor = table.Column<long>(nullable: false),
                    id_categoria = table.Column<long>(nullable: false),
                    id_marca = table.Column<long>(nullable: false),
                    id_unidad_medida = table.Column<long>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_producto", x => x.id_producto);
                    table.ForeignKey(
                        name: "fk_cat_categoria_id_categoria",
                        column: x => x.id_categoria,
                        principalSchema: "public",
                        principalTable: "cat_categoria",
                        principalColumn: "id_categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cat_marca_id_marca",
                        column: x => x.id_marca,
                        principalSchema: "public",
                        principalTable: "cat_marca",
                        principalColumn: "id_marca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cat_proveedor_id_proveedor",
                        column: x => x.id_proveedor,
                        principalSchema: "public",
                        principalTable: "cat_proveedor",
                        principalColumn: "id_proveedor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cat_unidad_medida_id_unidad_medida",
                        column: x => x.id_unidad_medida,
                        principalSchema: "public",
                        principalTable: "cat_unidad_medida",
                        principalColumn: "id_unidad_medida",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cat_producto_id_categoria",
                schema: "public",
                table: "cat_producto",
                column: "id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_cat_producto_id_marca",
                schema: "public",
                table: "cat_producto",
                column: "id_marca");

            migrationBuilder.CreateIndex(
                name: "IX_cat_producto_id_proveedor",
                schema: "public",
                table: "cat_producto",
                column: "id_proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_cat_producto_id_unidad_medida",
                schema: "public",
                table: "cat_producto",
                column: "id_unidad_medida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cat_producto",
                schema: "public");

            migrationBuilder.DropTable(
                name: "cat_categoria",
                schema: "public");

            migrationBuilder.DropTable(
                name: "cat_marca",
                schema: "public");

            migrationBuilder.DropTable(
                name: "cat_proveedor",
                schema: "public");

            migrationBuilder.DropTable(
                name: "cat_unidad_medida",
                schema: "public");
        }
    }
}
