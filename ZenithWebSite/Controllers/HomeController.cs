using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            DateTime thisMonday = DateTime.Today.AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 1);
            DateTime nextMonday = thisMonday.AddDays(7);

            var upcomingEvents = db.Events
                                .Where(e => e.DateFrom >= thisMonday && e.DateFrom < nextMonday && e.IsActive == true)
                                .OrderBy(e => e.DateFrom)
                                .Include(e => e.ActivityCategory);
            return View(upcomingEvents.ToList());
        }
    }
}