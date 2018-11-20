﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesAPI.Models;

namespace SalesAPI.Migrations
{
    [DbContext(typeof(SalesAPIContext))]
    partial class SalesAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("SalesAPI.Models.SalesItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Height");

                    b.Property<string>("Links");

                    b.Property<string>("PublishDate");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<int>("UpvoteCount");

                    b.Property<string>("Url");

                    b.Property<string>("Width");

                    b.HasKey("Id");

                    b.ToTable("SalesItem");
                });
#pragma warning restore 612, 618
        }
    }
}
