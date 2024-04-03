using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudianteEFC.Migrations
{
    /// <inheritdoc />
    public partial class AddProfesorMatricula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Matriculas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_ProfesorId",
                table: "Matriculas",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Profesores_ProfesorId",
                table: "Matriculas",
                column: "ProfesorId",
                principalTable: "Profesores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Profesores_ProfesorId",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_ProfesorId",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Matriculas");
        }
    }
}
