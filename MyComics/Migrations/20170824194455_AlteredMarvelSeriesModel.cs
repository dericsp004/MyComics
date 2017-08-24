using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyComics.Migrations
{
    public partial class AlteredMarvelSeriesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Summary_nextId",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Summary_previousId",
                table: "Series");

            migrationBuilder.RenameColumn(
                name: "previousId",
                table: "Series",
                newName: "PreviousId");

            migrationBuilder.RenameColumn(
                name: "nextId",
                table: "Series",
                newName: "NextId");

            migrationBuilder.RenameIndex(
                name: "IX_Series_previousId",
                table: "Series",
                newName: "IX_Series_PreviousId");

            migrationBuilder.RenameIndex(
                name: "IX_Series_nextId",
                table: "Series",
                newName: "IX_Series_NextId");

            migrationBuilder.AddColumn<int>(
                name: "SeriesNo",
                table: "Series",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Summary_NextId",
                table: "Series",
                column: "NextId",
                principalTable: "Summary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Summary_PreviousId",
                table: "Series",
                column: "PreviousId",
                principalTable: "Summary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Summary_NextId",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Summary_PreviousId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "SeriesNo",
                table: "Series");

            migrationBuilder.RenameColumn(
                name: "PreviousId",
                table: "Series",
                newName: "previousId");

            migrationBuilder.RenameColumn(
                name: "NextId",
                table: "Series",
                newName: "nextId");

            migrationBuilder.RenameIndex(
                name: "IX_Series_PreviousId",
                table: "Series",
                newName: "IX_Series_previousId");

            migrationBuilder.RenameIndex(
                name: "IX_Series_NextId",
                table: "Series",
                newName: "IX_Series_nextId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Summary_nextId",
                table: "Series",
                column: "nextId",
                principalTable: "Summary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Summary_previousId",
                table: "Series",
                column: "previousId",
                principalTable: "Summary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
