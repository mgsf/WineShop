using System;
using System.Collections.Generic;

namespace Catalog.Models
{
    public interface IWineRepository
    {
        IEnumerable<Wine> GetAllWines();
    }
}
