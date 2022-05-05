﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRegister.Models.Context;

namespace StudentRegister.Migrations
{
    [DbContext(typeof(LessonAssignmentContext))]
    [Migration("20220505174808_mig4")]
    partial class mig4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentRegister.Models.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentPresident")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("StudentRegister.Models.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Credit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LessonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LessonTeacher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonTerm")
                        .HasColumnType("int");

                    b.HasKey("LessonId");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("StudentRegister.Models.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StudentDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentNo")
                        .HasColumnType("int");

                    b.Property<string>("StudentSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentTerm")
                        .HasColumnType("int");

                    b.Property<DateTime>("SutdentSaveDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentRegister.Models.Entities.StudentLesson", b =>
                {
                    b.Property<int>("StudentLessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentLessonId");

                    b.HasIndex("LessonId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentLesson");
                });

            modelBuilder.Entity("StudentRegister.Models.Entities.Student", b =>
                {
                    b.HasOne("StudentRegister.Models.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("StudentRegister.Models.Entities.StudentLesson", b =>
                {
                    b.HasOne("StudentRegister.Models.Entities.Lesson", "Lesson")
                        .WithMany("StudentLesson")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentRegister.Models.Entities.Student", "Student")
                        .WithMany("StudentLesson")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentRegister.Models.Entities.Lesson", b =>
                {
                    b.Navigation("StudentLesson");
                });

            modelBuilder.Entity("StudentRegister.Models.Entities.Student", b =>
                {
                    b.Navigation("StudentLesson");
                });
#pragma warning restore 612, 618
        }
    }
}
