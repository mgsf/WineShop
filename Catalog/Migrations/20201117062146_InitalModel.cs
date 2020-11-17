using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Migrations
{
    public partial class InitalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    Year = table.Column<string>(maxLength: 20, nullable: true),
                    Age = table.Column<string>(maxLength: 20, nullable: true),
                    Varietal = table.Column<string>(maxLength: 50, nullable: true),
                    Size = table.Column<string>(maxLength: 20, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Image = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wines", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Wines",
                columns: new[] { "Id", "Age", "Country", "Image", "Name", "Price", "Size", "Type", "Varietal", "Year" },
                values: new object[,]
                {
                    { 1, "NA", "New Zeland", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/o/y/oyster-bay-chardonnay.jpg", "Oyster Bay Chardonnay", 4100.0, "750ml", "White Wine", "CHARDONNAY", "1896" },
                    { 2, "NA", "South Africa", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/b/e/bellingham-homestead-orch-chen-blanc.jpg", "Bellingham Homestead Orch Chenin Blanc", 3500.0, "750ml", "White Wine", "Chenin Blanc", "1937" },
                    { 3, "NA", "France", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/u/hugel-gewurztraminer.jpg", "Hugel Gewurztraminer", 5600.0, "750ml", "White Wine", "Gewurztraminer", "1500" },
                    { 4, "NA", "Australia", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/a/hardy-stamp-shiraz-cabernet.jpg", "Hardys Stamp Shiraz Cabernet", 2400.0, "750ml", "Red Wine", "SHIRAZ", "1389" },
                    { 5, "NA", "Australia", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/a/vasse-felix-premier-cabernet-merlot.jpg", "Vasse Felix Premier Cabernet Merlot", 5000.0, "750ml", "Red Wine", "Cabernet Merlot", "1457" },
                    { 6, "NA", "France", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/s/a/saint-joseph-deschants-rouge.jpg", "Saint Joseph Deschants Rouge", 8200.0, "750ml", "Red Wine", "SHIRAZ", "1765" },
                    { 7, "NA", "Australia", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/r/e/refreshing-ros_-wine-with-summer-berries.jpg", "Banrock Station - Rosé Wine With Summer Berries", 2400.0, "750ml", "Rose Wine", "Fruit Fusion", "2397" },
                    { 8, "NA", "United Kingdom", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/a/hattingley-rose.jpg", "Hattingley Rose", 7400.0, "750ml", "Rose Wine", "Grenache", "2165" },
                    { 9, "750ml", "France", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/p/i/pierre_mignon_rose_brut.jpg", "Pierre Mignon Rose Brut", 10000.0, "750ml", "Rose Wine", "ROSE SPARKLING WINE", "2401" },
                    { 10, "NA", "France", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/i/vin-mousseux-a-nos-amours-dem.jpg", "Vin Mousseux A Nos Amours Demi Sec", 2000.0, "750ml", "Sparkling", "NA", "2004" },
                    { 11, "NA", "France", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/c/h/charles-de-f_re-jean-louis-blanc-de-blancs-brut.jpg", "Charles De Fère Jean-Louis Blanc De Blancs Brut", 3300.0, "750ml", "Sparkling", "Non-Vintage Sparkling", "1325" },
                    { 12, "NA", "France", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/p/o/pol-roger-brut-reserve.jpg", "Pol Roger Brut Reserve", 16900.0, "750ml", "Sparkling", "CHAMPAGNE", "1225" },
                    { 13, "NA", "South Africa", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/t/h/the-beach-house-rose-wine.jpg", "The Beach House Rose Wine", 2300.0, "750ml", "Sweet", "Pinotage Rose", "1576" },
                    { 14, "NA", "Spain", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/e/ve_bot.jpg", "Torres Vina Esmeralda", 2800.0, "750ml", "Sweet", "Gewurztraminer", "1544" },
                    { 15, "750ml", "Australia", "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/c/r/crisp-white-wine-with-tropical-fruits.jpg", "Banrock Station - White Wine With Tropical Fruits", 2400.0, "750ml", "Sweet", "Fruit Fusion", "2399" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wines");
        }
    }
}
