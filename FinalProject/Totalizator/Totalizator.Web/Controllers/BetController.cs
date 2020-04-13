using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalizator.Business.Services.Interfaces;
using Totalizator.Shared;

namespace Totalizator.Web.Controllers
{
    public class BetController : Controller
    {
        private readonly IBetService betService;

        public BetController(IBetService betServ)
        {
            betService = betServ;
        }

        // GET: Bet
        public ActionResult Index()
        {
            IEnumerable<BetViewModel> bets = betService.GetAll();
            
            return View(bets);
        }
    }
}