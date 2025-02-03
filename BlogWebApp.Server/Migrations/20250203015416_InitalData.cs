using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogWebApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessContactDetails",
                columns: table => new
                {
                    BusinessContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessContactDetails", x => x.BusinessContactId);
                });

            migrationBuilder.CreateTable(
                name: "DynamicContent",
                columns: table => new
                {
                    DynamicContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicContent", x => x.DynamicContentID);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackData",
                columns: table => new
                {
                    FeedbackID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedbackDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedbackEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackData", x => x.FeedbackID);
                });

            migrationBuilder.CreateTable(
                name: "StaticContent",
                columns: table => new
                {
                    StaticContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticContent", x => x.StaticContentID);
                });

            migrationBuilder.InsertData(
                table: "BusinessContactDetails",
                columns: new[] { "BusinessContactId", "BusinessAddress", "BusinessEmail", "BusinessName", "BusinessPhone" },
                values: new object[,]
                {
                    { 1, "1600 Pennsylvania Avenue NW, Washington, DC 20500", "I Aint Giving you that (;", "On A Whim Studios", "(360) 360-3600" },
                    { 2, "1600 Pennsylvania Avenue NW, Washington, DC 20500", "jesse@toast.llc", "Toast LLC.", "(360) 555-5555" },
                    { 3, "1600 Pennsylvania Avenue NW, Washington, DC 20500", "Bogus@whatevenisthelimitforthelengthoftheemaildomainidontreallyknow.idk", "Bogus Industries", "(360) 555-5555" }
                });

            migrationBuilder.InsertData(
                table: "DynamicContent",
                columns: new[] { "DynamicContentID", "Author", "Body", "CreatedDate", "Description", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Dr. Meowdy", "This is a test of the first post made from the seeded data (:", new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9069), "Juan Post", new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9123), "Big First Post" },
                    { 2, "Not You", "This is another sample post of stuff. Idk, I making a post while I be snacking.", new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9125), "I dont really know what the post is or whatever.", new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9126), "What kind of Post is this?" }
                });

            migrationBuilder.InsertData(
                table: "FeedbackData",
                columns: new[] { "FeedbackID", "FeedbackDescription", "FeedbackEmail", "FeedbackName" },
                values: new object[,]
                {
                    { 1, "This design sucks. It doesnt exist!", "stuff@fauxemail.com", "Design" },
                    { 2, "Why Am I getting an error 418?", "coffee@teapot.com", "Server" }
                });

            migrationBuilder.InsertData(
                table: "StaticContent",
                columns: new[] { "StaticContentID", "Content", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Awesome Layout Content!", new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9171), new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9172), "Wireframe" },
                    { 2, "Have you read the Scrum Manifesto?", new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9174), new DateTime(2025, 2, 2, 17, 54, 15, 304, DateTimeKind.Local).AddTicks(9175), "Scrum Bible" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessContactDetails");

            migrationBuilder.DropTable(
                name: "DynamicContent");

            migrationBuilder.DropTable(
                name: "FeedbackData");

            migrationBuilder.DropTable(
                name: "StaticContent");
        }
    }
}
