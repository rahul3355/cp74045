﻿// <auto-generated />
using System;
using CP74045.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CP74045.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221209122950_Project_Team")]
    partial class Project_Team
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CP74045.Data.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminPassword");

                    b.Property<string>("AdminUsername");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CP74045.Data.Models.Agreement", b =>
                {
                    b.Property<int>("AgreementId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("AgreementFile");

                    b.HasKey("AgreementId");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("CP74045.Data.Models.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetType");

                    b.Property<string>("ModelNumber");

                    b.HasKey("AssetId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("CP74045.Data.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientAddress");

                    b.Property<string>("ClientGender");

                    b.Property<string>("ClientName");

                    b.Property<string>("ClientPassword");

                    b.Property<string>("ClientPhone");

                    b.Property<string>("ClientUsername");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CP74045.Data.Models.Client_Project", b =>
                {
                    b.Property<int>("CPId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("ProjectId");

                    b.HasKey("CPId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Client_Projects");
                });

            modelBuilder.Entity("CP74045.Data.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeDesignation");

                    b.Property<string>("EmployeeEmail");

                    b.Property<string>("EmployeeGender");

                    b.Property<string>("EmployeeLocation");

                    b.Property<string>("EmployeeName");

                    b.Property<string>("EmployeePassword");

                    b.Property<string>("EmployeePhone");

                    b.Property<string>("EmployeePicture");

                    b.Property<string>("EmployeeUsername");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CP74045.Data.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackendRequirements");

                    b.Property<string>("FrontendRequirements");

                    b.Property<int>("ProjectBudget");

                    b.Property<string>("ProjectDatabaseUsed");

                    b.Property<int>("ProjectDurationInDays");

                    b.Property<string>("ProjectInfo");

                    b.Property<string>("ProjectName");

                    b.Property<string>("ProjectStatus");

                    b.Property<string>("ProjectType");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CP74045.Data.Models.Project_Team", b =>
                {
                    b.Property<int>("PTId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectId");

                    b.Property<int>("TeamId");

                    b.HasKey("PTId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TeamId");

                    b.ToTable("Project_Teams");
                });

            modelBuilder.Entity("CP74045.Data.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamInfo");

                    b.Property<string>("TeamName");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("CP74045.Data.Models.Client_Project", b =>
                {
                    b.HasOne("CP74045.Data.Models.Client", "Client")
                        .WithMany("Client_Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CP74045.Data.Models.Project", "Project")
                        .WithMany("Client_Projects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CP74045.Data.Models.Project_Team", b =>
                {
                    b.HasOne("CP74045.Data.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CP74045.Data.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
