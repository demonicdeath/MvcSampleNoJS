using MTGTest.Entity;
using MTGTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGTest.Data.Repository
{
    public interface IBuyerResultRepository
    {
        IEnumerable<BuyingInfluenceResult> GetBuyingInfluence();
    }
}
