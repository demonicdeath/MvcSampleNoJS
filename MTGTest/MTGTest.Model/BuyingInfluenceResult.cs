using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGTest.Model
{
    public class BuyingInfluenceResult
    {
        public string id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public int siteId { get; set; }
        public string Name { get; set; }
        public System.DateTime LastLogin { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public bool BuyingInfluence { get; set; }
        public bool ConsumerBuyingInfluence { get; set; }
    }
}
