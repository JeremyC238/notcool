﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eIdeas.Data;

namespace eIdeas.Migrations
{
    [DbContext(typeof(IdeasContext))]
    partial class IdeasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eIdeas.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaID");

                    b.Property<DateTime>("UploadDate");

                    b.Property<string>("UserComment");

                    b.Property<string>("UserID");

                    b.Property<string>("UserName");

                    b.HasKey("CommentID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("eIdeas.Models.Idea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Problem");

                    b.Property<string>("Solution");

                    b.Property<string>("Status");

                    b.Property<string>("Team");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UploadDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Idea");
                });

            modelBuilder.Entity("eIdeas.Models.Like", b =>
                {
                    b.Property<int>("LikeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaID");

                    b.Property<bool>("Liked");

                    b.Property<string>("UserID");

                    b.HasKey("LikeID");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("eIdeas.Models.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaID");

                    b.Property<DateTime>("NotificationDate");

                    b.Property<string>("NotificationMessage");

                    b.Property<string>("TargetUserID");

                    b.Property<string>("UserID");

                    b.Property<string>("Username");

                    b.HasKey("NotificationID");

                    b.ToTable("Notifcation");
                });

            modelBuilder.Entity("eIdeas.Models.Subscribe", b =>
                {
                    b.Property<int>("SubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaID");

                    b.Property<bool>("Subscribed");

                    b.Property<string>("UserID");

                    b.HasKey("SubscriptionID");

                    b.ToTable("Subscribe");
                });
#pragma warning restore 612, 618
        }
    }
}
