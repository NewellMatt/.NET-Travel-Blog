using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace TravelBlog.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Experience_Location_LocationId", table: "Experience");
            migrationBuilder.DropForeignKey(name: "FK_People_Experience_ExperienceId", table: "People");
            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");
            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");
            migrationBuilder.RenameTable(
                name: "People",
                newName: "Peoples");
            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Location_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_People_Experience_ExperienceId",
                table: "Peoples",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Experience_Location_LocationId", table: "Experiences");
            migrationBuilder.DropForeignKey(name: "FK_People_Experience_ExperienceId", table: "Peoples");
            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");
            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");
            migrationBuilder.RenameTable(
                name: "People",
                newName: "Peoples");
            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Location_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_People_Experience_ExperienceId",
                table: "Peoples",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
