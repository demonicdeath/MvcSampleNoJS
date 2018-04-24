using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MTGTest.Entity;
using System.Data.Entity;
using MTGTest.Data.Repository;
using MTGTest.Model;

namespace MTGTest.Data.Repository
{
    public class BuyerResultRepository : IBuyerResultRepository
    {
        private readonly MTGEntities _context;

        public BuyerResultRepository(MTGEntities context)
        {
            _context = context;
        }

        public IEnumerable<BuyingInfluenceResult> GetBuyingInfluence()
        {   
            return AutoMapper.Mapper.Map<IEnumerable<BuyingInfluenceResult>>(_context.SP_BuyingInfluence());
        }
    }
}