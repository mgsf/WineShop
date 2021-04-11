using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WineWeb.Models;
using WineWeb.Services;

namespace WineWeb.Pages
{
    public partial class WineList
    {
        public IEnumerable<Wine> Wines { get; set; }

        [Inject]
        public IWineDataService WineDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //Use below two lines of code when loading local data
            //InitializeWines();  //- Mentioned below
            //return base.OnInitializedAsync();
            Wines = (await WineDataService.GetAllWines()).ToList();
            
        }

        
        private void InitializeWines()
        {
            var w1 = new Wine
            {
                Id = 1,
                Name = "Oyster Bay Chardonnay",
                Country = "New Zeland",
                Type = "White Wine",
                Year = "1896",
                Age = "NA",
                Varietal = "CHARDONNAY",
                Size = "750ml",
                Price = 4100,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/o/y/oyster-bay-chardonnay.jpg"
            };

            var w2 = new Wine
            {
                Id = 2,
                Name = "Bellingham Homestead Orch Chenin Blanc",
                Country = "South Africa",
                Type = "White Wine",
                Year = "1937",
                Age = "NA",
                Varietal = "Chenin Blanc",
                Size = "750ml",
                Price = 3500,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/b/e/bellingham-homestead-orch-chen-blanc.jpg"
            };

            var w3 = new Wine
            {
                Id = 3,
                Name = "Hugel Gewurztraminer",
                Country = "France",
                Type = "White Wine",
                Year = "1500",
                Age = "NA",
                Varietal = "Gewurztraminer",
                Size = "750ml",
                Price = 5600,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/u/hugel-gewurztraminer.jpg"
            };

            var w4 = new Wine
            {
                Id = 4,
                Name = "Hardys Stamp Shiraz Cabernet",
                Country = "Australia",
                Type = "Red Wine",
                Year = "1389",
                Age = "NA",
                Varietal = "SHIRAZ",
                Size = "750ml",
                Price = 2400,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/a/hardy-stamp-shiraz-cabernet.jpg"
            };

            var w5 = new Wine
            {
                Id = 5,
                Name = "Vasse Felix Premier Cabernet Merlot",
                Country = "Australia",
                Type = "Red Wine",
                Year = "1457",
                Age = "NA",
                Varietal = "Cabernet Merlot",
                Size = "750ml",
                Price = 5000,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/a/vasse-felix-premier-cabernet-merlot.jpg"
            };

            var w6 = new Wine
            {
                Id = 6,
                Name = "Saint Joseph Deschants Rouge",
                Country = "France",
                Type = "Red Wine",
                Year = "1765",
                Age = "NA",
                Varietal = "SHIRAZ",
                Size = "750ml",
                Price = 8200,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/s/a/saint-joseph-deschants-rouge.jpg"
            };

            var w7 = new Wine
            {
                Id = 7,
                Name = "Banrock Station - Rosé Wine With Summer Berries",
                Country = "Australia",
                Type = "Rose Wine",
                Year = "2397",
                Age = "NA",
                Varietal = "Fruit Fusion",
                Size = "750ml",
                Price = 2400,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/r/e/refreshing-ros_-wine-with-summer-berries.jpg"
            };

            var w8 = new Wine
            {
                Id = 8,
                Name = "Hattingley Rose",
                Country = "United Kingdom",
                Type = "Rose Wine",
                Year = "2165",
                Age = "NA",
                Varietal = "Grenache",
                Size = "750ml",
                Price = 7400,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/h/a/hattingley-rose.jpg"
            };

            var w9 = new Wine
            {
                Id = 9,
                Name = "Pierre Mignon Rose Brut",
                Country = "France",
                Type = "Rose Wine",
                Year = "2401",
                Age = "750ml",
                Varietal = "ROSE SPARKLING WINE",
                Size = "750ml",
                Price = 10000,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/p/i/pierre_mignon_rose_brut.jpg"
            };

            var w10 = new Wine
            {
                Id = 10,
                Name = "Vin Mousseux A Nos Amours Demi Sec",
                Country = "France",
                Type = "Sparkling",
                Year = "2004",
                Age = "NA",
                Varietal = "NA",
                Size = "750ml",
                Price = 2000,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/i/vin-mousseux-a-nos-amours-dem.jpg"
            };

            var w11 = new Wine
            {
                Id = 11,
                Name = "Charles De Fère Jean-Louis Blanc De Blancs Brut",
                Country = "France",
                Type = "Sparkling",
                Year = "1325",
                Age = "NA",
                Varietal = "Non-Vintage Sparkling",
                Size = "750ml",
                Price = 3300,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/c/h/charles-de-f_re-jean-louis-blanc-de-blancs-brut.jpg"
            };

            var w12 = new Wine
            {
                Id = 12,
                Name = "Pol Roger Brut Reserve",
                Country = "France",
                Type = "Sparkling",
                Year = "1225",
                Age = "NA",
                Varietal = "CHAMPAGNE",
                Size = "750ml",
                Price = 16900,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/p/o/pol-roger-brut-reserve.jpg"
            };

            var w13 = new Wine
            {
                Id = 13,
                Name = "The Beach House Rose Wine",
                Country = "South Africa",
                Type = "Sweet",
                Year = "1576",
                Age = "NA",
                Varietal = "Pinotage Rose",
                Size = "750ml",
                Price = 2300,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/t/h/the-beach-house-rose-wine.jpg"
            };

            var w14 = new Wine
            {
                Id = 14,
                Name = "Torres Vina Esmeralda",
                Country = "Spain",
                Type = "Sweet",
                Year = "1544",
                Age = "NA",
                Varietal = "Gewurztraminer",
                Size = "750ml",
                Price = 2800,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/v/e/ve_bot.jpg"
            };

            var w15 = new Wine
            {
                Id = 15,
                Name = "Banrock Station - White Wine With Tropical Fruits",
                Country = "Australia",
                Type = "Sweet",
                Year = "2399",
                Age = "750ml",
                Varietal = "Fruit Fusion",
                Size = "750ml",
                Price = 2400,
                Image = "https://wineworld.lk/media/catalog/product/cache/1/image/85e4522595efc69f496374d01ef2bf13/c/r/crisp-white-wine-with-tropical-fruits.jpg"
            };

            Wines = new List<Wine> { w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, w11, w12, w13, w14, w15 };
        }
       

    }


}

        