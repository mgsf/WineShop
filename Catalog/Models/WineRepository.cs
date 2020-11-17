using System;
using System.Collections.Generic;

namespace Catalog.Models
{
    public class WineRepository: IWineRepository
    {
        private readonly AppDbContext _appDbContext;

        public WineRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Wine> GetAllWines()
        {
            return _appDbContext.Wines;
        }
    }
}
