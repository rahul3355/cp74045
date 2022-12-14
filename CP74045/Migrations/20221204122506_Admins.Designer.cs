// <auto-generated />
using CP74045.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CP74045.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221204122506_Admins")]
    partial class Admins
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
#pragma warning restore 612, 618
        }
    }
}
