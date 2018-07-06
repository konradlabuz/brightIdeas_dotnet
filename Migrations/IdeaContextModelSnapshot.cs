﻿// <auto-generated />
using ideas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ideas.Migrations
{
    [DbContext(typeof(IdeaContext))]
    partial class IdeaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ideas.Models.Like", b =>
                {
                    b.Property<int>("likeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created_at");

                    b.Property<int>("postId");

                    b.Property<DateTime>("updated_at");

                    b.Property<int>("userId");

                    b.HasKey("likeId");

                    b.HasIndex("postId");

                    b.HasIndex("userId");

                    b.ToTable("likes");
                });

            modelBuilder.Entity("ideas.Models.Post", b =>
                {
                    b.Property<int>("postId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("content");

                    b.Property<DateTime>("created_at");

                    b.Property<int>("creatorId");

                    b.Property<bool>("currentUser");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("postId");

                    b.HasIndex("creatorId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("ideas.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("alias");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("userId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ideas.Models.Like", b =>
                {
                    b.HasOne("ideas.Models.Post", "post")
                        .WithMany("likes")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ideas.Models.User", "user")
                        .WithMany("liked")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ideas.Models.Post", b =>
                {
                    b.HasOne("ideas.Models.User", "creator")
                        .WithMany("created")
                        .HasForeignKey("creatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
