using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HobbyClub.Web.Models;

namespace HobbyClub.Web.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllEvents()
        {
            var events = new List<EventsView>();
            events.Add(new EventsView() { logoImg = "/Content/Images/events/mafia_logo.png", name = "Classic mafia", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            events.Add(new EventsView() { logoImg = "/Content/Images/events/salsa_logo.gif", name = "Salsa", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            events.Add(new EventsView() { logoImg = "/Content/Images/events/soccer_logo.png", name = "Soccer", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            events.Add(new EventsView() { logoImg = "/Content/Images/events/vegan_logo.jpg", name = "Vegan club", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            return View(new MainPageViewModel()
            {
                events = events
            });
        }
    }
}