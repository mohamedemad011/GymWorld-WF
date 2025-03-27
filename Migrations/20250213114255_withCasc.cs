using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymWorld.Migrations
{
    /// <inheritdoc />
    public partial class withCasc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
