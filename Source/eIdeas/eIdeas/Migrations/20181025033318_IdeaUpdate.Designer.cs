﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eIdeas.Data;

namespace eIdeas.Migrations
{
    [DbContext(typeof(IdeasContext))]
    [Migration("20181025033318_IdeaUpdate")]
    partial class IdeaUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}