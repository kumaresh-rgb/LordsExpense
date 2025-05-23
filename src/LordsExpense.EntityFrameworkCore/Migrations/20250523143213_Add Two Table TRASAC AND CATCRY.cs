using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LordsExpense.Migrations
{
    /// <inheritdoc />
    public partial class AddTwoTableTRASACANDCATCRY : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATGRY",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PARENT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATGRY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CATEGORIES_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalTable: "CATGRY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CATEGORIES_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TRASAC",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CATEGORY_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TRNC_TITLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRNC_AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TRNC_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATE_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRASAC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TRASAC_CATEGORY_ID",
                        column: x => x.CATEGORY_ID,
                        principalTable: "CATGRY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TRASAC_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CATGRY_PARENT_ID",
                table: "CATGRY",
                column: "PARENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CATGRY_USER_ID",
                table: "CATGRY",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TRASAC_CATEGORY_ID",
                table: "TRASAC",
                column: "CATEGORY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TRASAC_USER_ID",
                table: "TRASAC",
                column: "USER_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRASAC");

            migrationBuilder.DropTable(
                name: "CATGRY");
        }
    }
}
