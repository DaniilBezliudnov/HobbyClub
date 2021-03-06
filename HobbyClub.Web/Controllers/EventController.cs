﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HobbyClub.Web.Models;
using HobbyClub.Data.Abstract;
using HobbyClub.Data.Entities;

namespace HobbyClub.Web.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
        private IBaseRepository<Event> repository;

        public EventController(IBaseRepository<Event> eventRepository)
        {
            this.repository = eventRepository;
        }

        public ActionResult GetAllEvents()
        {

             return View(repository.GetAll());
             //var events = new List<Events>();
             //events.Add(new Events() { logoImg = "/Content/Images/events/mafia_logo.png", name = "Classic mafia", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
             //events.Add(new Events() { logoImg = "/Content/Images/events/salsa_logo.gif", name = "Salsa", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
             //events.Add(new Events() { logoImg = "/Content/Images/events/soccer_logo.png", name = "Soccer", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
             //events.Add(new Events() { logoImg = "/Content/Images/events/vegan_logo.jpg", name = "Vegan club", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });

             //return View(new EventViewModel()
             //{
             //    events = events,
             //});

        }
    }
}