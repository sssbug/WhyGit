﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Why.Data;

namespace Why.Data.Migrations
{
    [DbContext(typeof(WhyDbContext))]
    [Migration("20221117151311_WhyDb10")]
    partial class WhyDb10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Why.Data.Models.Biography", b =>
                {
                    b.Property<int>("BiographyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BiographyContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiographyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiographyUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ThumbId")
                        .HasColumnType("int");

                    b.Property<int>("ThumbsId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("BiographyId");

                    b.HasIndex("ThumbId");

                    b.HasIndex("UserId");

                    b.ToTable("Biographies");
                });

            modelBuilder.Entity("Why.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Why.Data.Models.Chat", b =>
                {
                    b.Property<int>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChatContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChatFirstUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChatSecondUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChatTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChatUsersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Why.Data.Models.ChatMessage", b =>
                {
                    b.Property<int>("ChatMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChatId")
                        .HasColumnType("int");

                    b.Property<string>("ChatMessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChatMessageFirstUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChatMessageSecondUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChatMessageUsersName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChatMessageId");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("Why.Data.Models.Thumb", b =>
                {
                    b.Property<int>("ThumbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThumbClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UsersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserssId")
                        .HasColumnType("int");

                    b.HasKey("ThumbId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Thumbs");
                });

            modelBuilder.Entity("Why.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Why.Data.Models.Biography", b =>
                {
                    b.HasOne("Why.Data.Models.Thumb", "Thumb")
                        .WithMany("ThumbBiography")
                        .HasForeignKey("ThumbId");

                    b.HasOne("Why.Data.Models.User", "User")
                        .WithMany("UserBiography")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Why.Data.Models.Chat", b =>
                {
                    b.HasOne("Why.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Why.Data.Models.ChatMessage", b =>
                {
                    b.HasOne("Why.Data.Models.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId");
                });

            modelBuilder.Entity("Why.Data.Models.Thumb", b =>
                {
                    b.HasOne("Why.Data.Models.Category", null)
                        .WithMany("CategoryThumbs")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Why.Data.Models.User", "User")
                        .WithMany("UserThumb")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
