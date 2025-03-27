using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymWorld.Migrations
{
    /// <inheritdoc />
    public partial class cascRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId",
                table: "TrainerMembers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
