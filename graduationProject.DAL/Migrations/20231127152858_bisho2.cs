﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace graduationProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class bisho2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AverageRate",
                table: "Doctors",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageRate",
                table: "Doctors");
        }
    }
}
