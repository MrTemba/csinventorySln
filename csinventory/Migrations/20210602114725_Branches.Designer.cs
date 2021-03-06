// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csinventory.Models;

namespace csinventory.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20210602114725_Branches")]
    partial class Branches
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("csinventory.Models.Branch", b =>
                {
                    b.Property<long>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchManager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("csinventory.Models.Part", b =>
                {
                    b.Property<long>("PartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PartNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("ReWorkable")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("PartID");

                    b.ToTable("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}
