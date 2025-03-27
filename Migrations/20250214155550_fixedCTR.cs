using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymWorld.Migrations
{
    /// <inheritdoc />
    public partial class fixedCTR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberClasses_Classes_ClassId1",
                table: "MemberClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberClasses_Members_MemberId1",
                table: "MemberClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Members_MemberId1",
                table: "TrainerMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId1",
                table: "TrainerMembers");

            migrationBuilder.DropIndex(
                name: "IX_TrainerMembers_MemberId1",
                table: "TrainerMembers");

            migrationBuilder.DropIndex(
                name: "IX_TrainerMembers_TrainerId1",
                table: "TrainerMembers");

            migrationBuilder.DropIndex(
                name: "IX_MemberClasses_ClassId1",
                table: "MemberClasses");

            migrationBuilder.DropIndex(
                name: "IX_MemberClasses_MemberId1",
                table: "MemberClasses");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "TrainerMembers");

            migrationBuilder.DropColumn(
                name: "TrainerId1",
                table: "TrainerMembers");

            migrationBuilder.DropColumn(
                name: "ClassId1",
                table: "MemberClasses");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "MemberClasses");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers");

            migrationBuilder.AddColumn<int>(
                name: "MemberId1",
                table: "TrainerMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerId1",
                table: "TrainerMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassId1",
                table: "MemberClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemberId1",
                table: "MemberClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TrainerMembers_MemberId1",
                table: "TrainerMembers",
                column: "MemberId1");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerMembers_TrainerId1",
                table: "TrainerMembers",
                column: "TrainerId1");

            migrationBuilder.CreateIndex(
                name: "IX_MemberClasses_ClassId1",
                table: "MemberClasses",
                column: "ClassId1");

            migrationBuilder.CreateIndex(
                name: "IX_MemberClasses_MemberId1",
                table: "MemberClasses",
                column: "MemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberClasses_Classes_ClassId",
                table: "MemberClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberClasses_Classes_ClassId1",
                table: "MemberClasses",
                column: "ClassId1",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberClasses_Members_MemberId1",
                table: "MemberClasses",
                column: "MemberId1",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Members_MemberId",
                table: "TrainerMembers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Members_MemberId1",
                table: "TrainerMembers",
                column: "MemberId1",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerMembers_Trainers_TrainerId1",
                table: "TrainerMembers",
                column: "TrainerId1",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
