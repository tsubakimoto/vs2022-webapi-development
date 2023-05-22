using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VS2022WebApiDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class sqlite_migration_609 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "sayed@example.com", "Sayed Hashimi", "555-111-2222" },
                    { 2, "mads@example.com", "Mads Kristensen", "555-111-3333" },
                    { 3, "elineb@example.com", "Eline Barstad", "555-111-4444" },
                    { 4, "theol@example.com", "Theodore Lamy", "555-111-5555" },
                    { 5, "mariaz@example.com", "María Zelaya", "555-111-6666" },
                    { 6, "kubans@example.com", "Kubanychbek Sagynbek", "555-111-7777" },
                    { 7, "deniseb@example.com", "Denise Bourgeois", "555-111-8888" },
                    { 8, "robind@example.com", "Robin Danielsen", "555-111-9999" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
