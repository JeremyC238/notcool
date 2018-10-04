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

            modelBuilder.Entity("eIdeas.Models.Idea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaNo");

                    b.Property<string>("Name");

                    b.Property<string>("Solution");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UploadDate");

                    b.HasKey("ID");

                    b.ToTable("Idea");
                });
#pragma warning restore 612, 618
        }
    }
}
