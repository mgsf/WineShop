using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WineWeb.Models;

namespace WineWeb.Services
{
    public interface IWineDataService
    {
        Task<IEnumerable<Wine>> GetAllWines();
    }
}
