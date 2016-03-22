using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MvcMusicStore.Models;

namespace MvcMusicStore.Migrations.MusicStoreEntitiesMigrations
{
    [DbContext(typeof(MusicStoreEntities))]
    [Migration("20160322071225_CreateMusicStoreDatabaseSchema")]
    partial class CreateMusicStoreDatabaseSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("MvcMusicStore.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlbumArtUrl");

                    b.Property<int>("ArtistId");

                    b.Property<int>("GenreId");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MvcMusicStore.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MvcMusicStore.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MvcMusicStore.Models.Album", b =>
                {
                    b.HasOne("MvcMusicStore.Models.Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.HasOne("MvcMusicStore.Models.Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");
                });
        }
    }
}
