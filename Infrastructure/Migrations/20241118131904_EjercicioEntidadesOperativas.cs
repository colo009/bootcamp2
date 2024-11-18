using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EjercicioEntidadesOperativas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomersEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    EntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersEntities_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersEntities_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntitiesProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntitiesProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntitiesProducts_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersEntitiesProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityProductId = table.Column<int>(type: "integer", nullable: false),
                    CustomerEntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersEntitiesProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersEntitiesProducts_CustomersEntities_CustomerEntityId",
                        column: x => x.CustomerEntityId,
                        principalTable: "CustomersEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersEntitiesProducts_EntitiesProducts_EntityProductId",
                        column: x => x.EntityProductId,
                        principalTable: "EntitiesProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomersEntities_CustomerId_EntityId",
                table: "CustomersEntities",
                columns: new[] { "CustomerId", "EntityId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersEntities_EntityId",
                table: "CustomersEntities",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersEntitiesProducts_CustomerEntityId_EntityProductId",
                table: "CustomersEntitiesProducts",
                columns: new[] { "CustomerEntityId", "EntityProductId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersEntitiesProducts_EntityProductId",
                table: "CustomersEntitiesProducts",
                column: "EntityProductId");

            migrationBuilder.CreateIndex(
                name: "IX_EntitiesProducts_EntityId",
                table: "EntitiesProducts",
                column: "EntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersEntitiesProducts");

            migrationBuilder.DropTable(
                name: "CustomersEntities");

            migrationBuilder.DropTable(
                name: "EntitiesProducts");

            migrationBuilder.DropTable(
                name: "Entities");
        }
    }
}
