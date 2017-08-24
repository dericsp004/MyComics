using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyComics.Models;

namespace MyComics.Migrations
{
    [DbContext(typeof(ComicsContext))]
    [Migration("20170824175246_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyComics.Models.Marvel.Characters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Available");

                    b.Property<string>("CollectionURI");

                    b.Property<int>("Returned");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Comics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Available");

                    b.Property<string>("CollectionURI");

                    b.Property<int>("Returned");

                    b.HasKey("Id");

                    b.ToTable("Comics");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Creators", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Available");

                    b.Property<string>("CollectionURI");

                    b.Property<int>("Returned");

                    b.HasKey("Id");

                    b.ToTable("Creators");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Available");

                    b.Property<string>("CollectionURI");

                    b.Property<int>("Returned");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CharactersId");

                    b.Property<int?>("ComicsId");

                    b.Property<int?>("CreatorsId");

                    b.Property<string>("Description");

                    b.Property<int>("EndYear");

                    b.Property<int?>("EventsId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Rating");

                    b.Property<string>("ResourceURI");

                    b.Property<int>("StartYear");

                    b.Property<int?>("StoriesId");

                    b.Property<string>("ThumbnailId");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<int?>("nextId");

                    b.Property<int?>("previousId");

                    b.HasKey("Id");

                    b.HasIndex("CharactersId");

                    b.HasIndex("ComicsId");

                    b.HasIndex("CreatorsId");

                    b.HasIndex("EventsId");

                    b.HasIndex("StoriesId");

                    b.HasIndex("ThumbnailId");

                    b.HasIndex("nextId");

                    b.HasIndex("previousId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Stories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Available");

                    b.Property<string>("CollectionURI");

                    b.Property<int>("Returned");

                    b.HasKey("Id");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Summary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ComicsId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("EventsId");

                    b.Property<string>("Name");

                    b.Property<string>("ResourceURI");

                    b.HasKey("Id");

                    b.HasIndex("ComicsId");

                    b.HasIndex("EventsId");

                    b.ToTable("Summary");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Summary");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Thumbnail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Extension");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.ToTable("Thumbnail");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Url", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SeriesId");

                    b.Property<string>("Type");

                    b.Property<string>("UrlString");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("Url");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.PersonSummary", b =>
                {
                    b.HasBaseType("MyComics.Models.Marvel.Summary");

                    b.Property<int?>("CharactersId");

                    b.Property<int?>("CreatorsId");

                    b.Property<string>("Role");

                    b.HasIndex("CharactersId");

                    b.HasIndex("CreatorsId");

                    b.ToTable("PersonSummary");

                    b.HasDiscriminator().HasValue("PersonSummary");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.StorySummary", b =>
                {
                    b.HasBaseType("MyComics.Models.Marvel.Summary");

                    b.Property<int?>("StoriesId");

                    b.Property<string>("Type");

                    b.HasIndex("StoriesId");

                    b.ToTable("StorySummary");

                    b.HasDiscriminator().HasValue("StorySummary");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Series", b =>
                {
                    b.HasOne("MyComics.Models.Marvel.Characters", "Characters")
                        .WithMany()
                        .HasForeignKey("CharactersId");

                    b.HasOne("MyComics.Models.Marvel.Comics", "Comics")
                        .WithMany()
                        .HasForeignKey("ComicsId");

                    b.HasOne("MyComics.Models.Marvel.Creators", "Creators")
                        .WithMany()
                        .HasForeignKey("CreatorsId");

                    b.HasOne("MyComics.Models.Marvel.Events", "Events")
                        .WithMany()
                        .HasForeignKey("EventsId");

                    b.HasOne("MyComics.Models.Marvel.Stories", "Stories")
                        .WithMany()
                        .HasForeignKey("StoriesId");

                    b.HasOne("MyComics.Models.Marvel.Thumbnail", "Thumbnail")
                        .WithMany()
                        .HasForeignKey("ThumbnailId");

                    b.HasOne("MyComics.Models.Marvel.Summary", "next")
                        .WithMany()
                        .HasForeignKey("nextId");

                    b.HasOne("MyComics.Models.Marvel.Summary", "previous")
                        .WithMany()
                        .HasForeignKey("previousId");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Summary", b =>
                {
                    b.HasOne("MyComics.Models.Marvel.Comics")
                        .WithMany("Items")
                        .HasForeignKey("ComicsId");

                    b.HasOne("MyComics.Models.Marvel.Events")
                        .WithMany("Items")
                        .HasForeignKey("EventsId");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.Url", b =>
                {
                    b.HasOne("MyComics.Models.Marvel.Series")
                        .WithMany("Urls")
                        .HasForeignKey("SeriesId");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.PersonSummary", b =>
                {
                    b.HasOne("MyComics.Models.Marvel.Characters")
                        .WithMany("Items")
                        .HasForeignKey("CharactersId");

                    b.HasOne("MyComics.Models.Marvel.Creators")
                        .WithMany("Items")
                        .HasForeignKey("CreatorsId");
                });

            modelBuilder.Entity("MyComics.Models.Marvel.StorySummary", b =>
                {
                    b.HasOne("MyComics.Models.Marvel.Stories")
                        .WithMany("Items")
                        .HasForeignKey("StoriesId");
                });
        }
    }
}
