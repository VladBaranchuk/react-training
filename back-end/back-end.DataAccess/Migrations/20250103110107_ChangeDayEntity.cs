﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDayEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EarlyWeight",
                table: "Days",
                newName: "MorningWeight");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Days",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Days");

            migrationBuilder.RenameColumn(
                name: "MorningWeight",
                table: "Days",
                newName: "EarlyWeight");
        }
    }
}
