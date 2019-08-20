using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestPromart.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    NIdP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sku = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.NIdP);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    NId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ruc = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.NId);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    NIdS = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkuManual = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.NIdS);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicios",
                columns: table => new
                {
                    NIdSo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Turno = table.Column<string>(nullable: true),
                    FechaEstimada = table.Column<DateTime>(nullable: false),
                    Observacion = table.Column<string>(nullable: true),
                    FechaRegistro = table.Column<int>(nullable: false),
                    IdProveedor = table.Column<int>(nullable: false),
                    NIdProvNId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicios", x => x.NIdSo);
                    table.ForeignKey(
                        name: "FK_OrdenServicios_Proveedores_NIdProvNId",
                        column: x => x.NIdProvNId,
                        principalTable: "Proveedores",
                        principalColumn: "NId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicioDet",
                columns: table => new
                {
                    NIdSo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdServicioDetalle = table.Column<int>(nullable: false),
                    OrdServicioNIdSo = table.Column<int>(nullable: true),
                    IdServicio = table.Column<int>(nullable: false),
                    ServiciosNIdS = table.Column<int>(nullable: true),
                    IdProducto = table.Column<int>(nullable: false),
                    ProductosNIdP = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicioDet", x => x.NIdSo);
                    table.ForeignKey(
                        name: "FK_OrdenServicioDet_OrdenServicios_OrdServicioNIdSo",
                        column: x => x.OrdServicioNIdSo,
                        principalTable: "OrdenServicios",
                        principalColumn: "NIdSo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicioDet_Productos_ProductosNIdP",
                        column: x => x.ProductosNIdP,
                        principalTable: "Productos",
                        principalColumn: "NIdP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicioDet_Servicios_ServiciosNIdS",
                        column: x => x.ServiciosNIdS,
                        principalTable: "Servicios",
                        principalColumn: "NIdS",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioDet_OrdServicioNIdSo",
                table: "OrdenServicioDet",
                column: "OrdServicioNIdSo");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioDet_ProductosNIdP",
                table: "OrdenServicioDet",
                column: "ProductosNIdP");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioDet_ServiciosNIdS",
                table: "OrdenServicioDet",
                column: "ServiciosNIdS");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicios_NIdProvNId",
                table: "OrdenServicios",
                column: "NIdProvNId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenServicioDet");

            migrationBuilder.DropTable(
                name: "OrdenServicios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
