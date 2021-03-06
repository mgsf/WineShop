﻿// <auto-generated />
using Catalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Catalog.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Catalog.Models.Wine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Varietal")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Wines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = "NA",
                            Country = "New Zeland",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/o/y/oyster-bay-chardonnay.jpg",
                            Name = "Oyster Bay Chardonnay",
                            Price = 4100.0,
                            Size = "750ml",
                            Type = "White Wine",
                            Varietal = "CHARDONNAY",
                            Year = "1896"
                        },
                        new
                        {
                            Id = 2,
                            Age = "NA",
                            Country = "South Africa",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/b/e/bellingham-homestead-orch-chen-blanc.jpg",
                            Name = "Bellingham Homestead Orch Chenin Blanc",
                            Price = 3500.0,
                            Size = "750ml",
                            Type = "White Wine",
                            Varietal = "Chenin Blanc",
                            Year = "1937"
                        },
                        new
                        {
                            Id = 3,
                            Age = "NA",
                            Country = "France",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/u/hugel-gewurztraminer.jpg",
                            Name = "Hugel Gewurztraminer",
                            Price = 5600.0,
                            Size = "750ml",
                            Type = "White Wine",
                            Varietal = "Gewurztraminer",
                            Year = "1500"
                        },
                        new
                        {
                            Id = 4,
                            Age = "NA",
                            Country = "Australia",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/a/hardy-stamp-shiraz-cabernet.jpg",
                            Name = "Hardys Stamp Shiraz Cabernet",
                            Price = 2400.0,
                            Size = "750ml",
                            Type = "Red Wine",
                            Varietal = "SHIRAZ",
                            Year = "1389"
                        },
                        new
                        {
                            Id = 5,
                            Age = "NA",
                            Country = "Australia",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/a/vasse-felix-premier-cabernet-merlot.jpg",
                            Name = "Vasse Felix Premier Cabernet Merlot",
                            Price = 5000.0,
                            Size = "750ml",
                            Type = "Red Wine",
                            Varietal = "Cabernet Merlot",
                            Year = "1457"
                        },
                        new
                        {
                            Id = 6,
                            Age = "NA",
                            Country = "France",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/s/a/saint-joseph-deschants-rouge.jpg",
                            Name = "Saint Joseph Deschants Rouge",
                            Price = 8200.0,
                            Size = "750ml",
                            Type = "Red Wine",
                            Varietal = "SHIRAZ",
                            Year = "1765"
                        },
                        new
                        {
                            Id = 7,
                            Age = "NA",
                            Country = "Australia",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/r/e/refreshing-ros_-wine-with-summer-berries.jpg",
                            Name = "Banrock Station - Rosé Wine With Summer Berries",
                            Price = 2400.0,
                            Size = "750ml",
                            Type = "Rose Wine",
                            Varietal = "Fruit Fusion",
                            Year = "2397"
                        },
                        new
                        {
                            Id = 8,
                            Age = "NA",
                            Country = "United Kingdom",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/a/hattingley-rose.jpg",
                            Name = "Hattingley Rose",
                            Price = 7400.0,
                            Size = "750ml",
                            Type = "Rose Wine",
                            Varietal = "Grenache",
                            Year = "2165"
                        },
                        new
                        {
                            Id = 9,
                            Age = "750ml",
                            Country = "France",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/p/i/pierre_mignon_rose_brut.jpg",
                            Name = "Pierre Mignon Rose Brut",
                            Price = 10000.0,
                            Size = "750ml",
                            Type = "Rose Wine",
                            Varietal = "ROSE SPARKLING WINE",
                            Year = "2401"
                        },
                        new
                        {
                            Id = 10,
                            Age = "NA",
                            Country = "France",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/i/vin-mousseux-a-nos-amours-dem.jpg",
                            Name = "Vin Mousseux A Nos Amours Demi Sec",
                            Price = 2000.0,
                            Size = "750ml",
                            Type = "Sparkling",
                            Varietal = "NA",
                            Year = "2004"
                        },
                        new
                        {
                            Id = 11,
                            Age = "NA",
                            Country = "France",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/c/h/charles-de-f_re-jean-louis-blanc-de-blancs-brut.jpg",
                            Name = "Charles De Fère Jean-Louis Blanc De Blancs Brut",
                            Price = 3300.0,
                            Size = "750ml",
                            Type = "Sparkling",
                            Varietal = "Non-Vintage Sparkling",
                            Year = "1325"
                        },
                        new
                        {
                            Id = 12,
                            Age = "NA",
                            Country = "France",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/p/o/pol-roger-brut-reserve.jpg",
                            Name = "Pol Roger Brut Reserve",
                            Price = 16900.0,
                            Size = "750ml",
                            Type = "Sparkling",
                            Varietal = "CHAMPAGNE",
                            Year = "1225"
                        },
                        new
                        {
                            Id = 13,
                            Age = "NA",
                            Country = "South Africa",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/t/h/the-beach-house-rose-wine.jpg",
                            Name = "The Beach House Rose Wine",
                            Price = 2300.0,
                            Size = "750ml",
                            Type = "Sweet",
                            Varietal = "Pinotage Rose",
                            Year = "1576"
                        },
                        new
                        {
                            Id = 14,
                            Age = "NA",
                            Country = "Spain",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/e/ve_bot.jpg",
                            Name = "Torres Vina Esmeralda",
                            Price = 2800.0,
                            Size = "750ml",
                            Type = "Sweet",
                            Varietal = "Gewurztraminer",
                            Year = "1544"
                        },
                        new
                        {
                            Id = 15,
                            Age = "750ml",
                            Country = "Australia",
                            Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/c/r/crisp-white-wine-with-tropical-fruits.jpg",
                            Name = "Banrock Station - White Wine With Tropical Fruits",
                            Price = 2400.0,
                            Size = "750ml",
                            Type = "Sweet",
                            Varietal = "Fruit Fusion",
                            Year = "2399"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
