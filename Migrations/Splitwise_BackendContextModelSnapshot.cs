﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Splitwise_Backend.Models;
using System;

namespace Splitwise_Backend.Migrations
{
    [DbContext(typeof(Splitwise_BackendContext))]
    partial class Splitwise_BackendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Splitwise_Backend.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExpenseId");

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<DateTime>("Created_At");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("Deleted_At");

                    b.Property<string>("Description");

                    b.Property<string>("Details");

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("ExpenseId");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Friend", b =>
                {
                    b.Property<int>("FriendId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Balance");

                    b.Property<string>("Email");

                    b.Property<int?>("ExpenseId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("RegistrationStatus");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("FriendId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Friend");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryCode");

                    b.Property<int?>("ExpenseId");

                    b.Property<int?>("FriendId");

                    b.Property<string>("GroupName");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("GroupId");

                    b.HasIndex("ExpenseId");

                    b.HasIndex("FriendId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Balance");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GroupId");

                    b.Property<string>("LastName");

                    b.HasKey("MemberId");

                    b.HasIndex("GroupId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("From");

                    b.Property<int?>("GroupId");

                    b.Property<string>("To");

                    b.HasKey("PaymentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Picture", b =>
                {
                    b.Property<int>("Picture_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FriendId");

                    b.Property<string>("Large");

                    b.Property<string>("Medium");

                    b.Property<string>("Small");

                    b.Property<int?>("UserId");

                    b.HasKey("Picture_Id");

                    b.HasIndex("FriendId");

                    b.HasIndex("UserId");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<int?>("ExpenseId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Registration");

                    b.HasKey("UserId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Category", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Expense")
                        .WithMany("Category")
                        .HasForeignKey("ExpenseId");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Friend", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Expense")
                        .WithMany("Friend")
                        .HasForeignKey("ExpenseId");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Group", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Expense")
                        .WithMany("Group")
                        .HasForeignKey("ExpenseId");

                    b.HasOne("Splitwise_Backend.Models.Friend")
                        .WithMany("Group")
                        .HasForeignKey("FriendId");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Member", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Group")
                        .WithMany("Member")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Payment", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Group")
                        .WithMany("Payment")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.Picture", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Friend")
                        .WithMany("Picture")
                        .HasForeignKey("FriendId");

                    b.HasOne("Splitwise_Backend.Models.User")
                        .WithMany("Picture")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.SubCategory", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Category")
                        .WithMany("Sub")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Splitwise_Backend.Models.User", b =>
                {
                    b.HasOne("Splitwise_Backend.Models.Expense")
                        .WithMany("User")
                        .HasForeignKey("ExpenseId");
                });
#pragma warning restore 612, 618
        }
    }
}
