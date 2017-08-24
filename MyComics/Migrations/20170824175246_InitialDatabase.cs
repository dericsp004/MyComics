using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyComics.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Available = table.Column<int>(nullable: false),
                    CollectionURI = table.Column<string>(nullable: true),
                    Returned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Available = table.Column<int>(nullable: false),
                    CollectionURI = table.Column<string>(nullable: true),
                    Returned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Available = table.Column<int>(nullable: false),
                    CollectionURI = table.Column<string>(nullable: true),
                    Returned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Available = table.Column<int>(nullable: false),
                    CollectionURI = table.Column<string>(nullable: true),
                    Returned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Available = table.Column<int>(nullable: false),
                    CollectionURI = table.Column<string>(nullable: true),
                    Returned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Thumbnail",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Extension = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thumbnail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComicsId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    EventsId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ResourceURI = table.Column<string>(nullable: true),
                    CharactersId = table.Column<int>(nullable: true),
                    CreatorsId = table.Column<int>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    StoriesId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Summary_Comics_ComicsId",
                        column: x => x.ComicsId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Summary_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Summary_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Summary_Creators_CreatorsId",
                        column: x => x.CreatorsId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Summary_Stories_StoriesId",
                        column: x => x.StoriesId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharactersId = table.Column<int>(nullable: true),
                    ComicsId = table.Column<int>(nullable: true),
                    CreatorsId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndYear = table.Column<int>(nullable: false),
                    EventsId = table.Column<int>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    ResourceURI = table.Column<string>(nullable: true),
                    StartYear = table.Column<int>(nullable: false),
                    StoriesId = table.Column<int>(nullable: true),
                    ThumbnailId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    nextId = table.Column<int>(nullable: true),
                    previousId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Comics_ComicsId",
                        column: x => x.ComicsId,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Creators_CreatorsId",
                        column: x => x.CreatorsId,
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Stories_StoriesId",
                        column: x => x.StoriesId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Thumbnail_ThumbnailId",
                        column: x => x.ThumbnailId,
                        principalTable: "Thumbnail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Summary_nextId",
                        column: x => x.nextId,
                        principalTable: "Summary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Series_Summary_previousId",
                        column: x => x.previousId,
                        principalTable: "Summary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Url",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    SeriesId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    UrlString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Url", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Url_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Series_CharactersId",
                table: "Series",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_ComicsId",
                table: "Series",
                column: "ComicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CreatorsId",
                table: "Series",
                column: "CreatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_EventsId",
                table: "Series",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_StoriesId",
                table: "Series",
                column: "StoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_ThumbnailId",
                table: "Series",
                column: "ThumbnailId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_nextId",
                table: "Series",
                column: "nextId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_previousId",
                table: "Series",
                column: "previousId");

            migrationBuilder.CreateIndex(
                name: "IX_Summary_ComicsId",
                table: "Summary",
                column: "ComicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Summary_EventsId",
                table: "Summary",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Summary_CharactersId",
                table: "Summary",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Summary_CreatorsId",
                table: "Summary",
                column: "CreatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Summary_StoriesId",
                table: "Summary",
                column: "StoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Url_SeriesId",
                table: "Url",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Url");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Thumbnail");

            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Creators");

            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
