using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NameSexMovie.Data.Migrations
{
    public partial class book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Information",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "book",
                table: "Information",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "food",
                table: "Information",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "music",
                table: "Information",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "book",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "food",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "music",
                table: "Information");
        }
    }
}
