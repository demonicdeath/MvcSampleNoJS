using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTGTest.Data.Repository;

namespace MTGTest.Controllers
{
    public class MTGResultController : Controller
    {
        private readonly IBuyerResultRepository _buyerResultRepository;

        public MTGResultController(IBuyerResultRepository buyerResultRepository)
        {
            _buyerResultRepository = buyerResultRepository;
        }

        public ActionResult Index()
        {
            return View(_buyerResultRepository.GetBuyingInfluence());
        }
    }
}
