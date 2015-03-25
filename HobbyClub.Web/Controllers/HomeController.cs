using HobbyClub.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HobbyClub.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Main()
        {
            #region заглушка
            var slider = new List<SliderView>();
            slider.Add(new SliderView() { img = "/Content/Images/slider/bg1.jpg", name = "interest", description = "description" });
            slider.Add(new SliderView() { img = "/Content/Images/slider/bg2.jpg", name = "interest", description = "description" });

            var interests = new List<InterestsView>();
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/01.jpg", name = "Board Games", previewImg = "images/portfolio/full.jpg" });
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/02.jpg", name = "Soccer", previewImg = "images/portfolio/full.jpg" });
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/03.jpg", name = "Traveling", previewImg = "images/portfolio/full.jpg" });
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/04.jpg", name = "Dancing", previewImg = "images/portfolio/full.jpg" });
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/05.jpg", name = "Food & Drink/Cooking", previewImg = "images/portfolio/full.jpg" });
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/06.jpg", name = "Outdoors & Adventure/Diving", previewImg = "images/portfolio/full.jpg" });
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/07.jpg", name = "Running", previewImg = "images/portfolio/full.jpg" });
            interests.Add(new InterestsView() { img = "/Content/Images/portfolio/08.jpg", name = "Pets and Animals", previewImg = "images/portfolio/full.jpg" });

            var groups = new List<GroupsView>();
            groups.Add(new GroupsView() { logoImg = "/Content/Images/groups/travel_logo.png", name = "L’viv Travel Group", description = " Come to a Travel meetup to relive adventures, share photos from around the world and get first-hand  recommendations on new exotic destinations. Find fun, laughs, travel buddy!" });
            groups.Add(new GroupsView() { logoImg = "/Content/Images/groups/salsa_logo.jpg", name = "Salsa Dance Group", description = "Bailamos! Never tried salsa before? Already dance? Salsa Dance Meetup members welcome  you to Meet up with us and explore Salsa social dance scene." });
            groups.Add(new GroupsView() { logoImg = "/Content/Images/groups/soccer_logo.jpg", name = "Soccer Club Kyiv", description = "This is an open and friendly soccer club.  We welcome high school students, women, beginners and all. This club can be a HUB for those who simply wish to play soccer." });
            groups.Add(new GroupsView() { logoImg = "/Content/Images/groups/hiking_logo.jpg", name = "Bukovel Hiking Club", description = "Our vision is to create a network of outdoors enthusiasts to share our adventures, to learn from, to have fun with, and to create life long friends. Have fun Hiking and hope to see you soon!" });
            groups.Add(new GroupsView() { logoImg = "/Content/Images/groups/dog_paw_logo.jpg", name = "City Paws", description = "City Paws is a social group of pups and people who get together for fun events in and around the city of Odessa. No matter what we are doing with our pups one thing is for sure... we always have a great time!" });
            groups.Add(new GroupsView() { logoImg = "/Content/Images/groups/poker_logo.jpg", name = "The Kyiv Poker Club", description = " The Kyiv Poker Club is the place to learn how to play Poker and find information about the local poker scene.  Poker is an exciting and fun game  and if you play or wish to learn how to play." });

            var events = new List<EventsView>();
            events.Add(new EventsView() { logoImg = "/Content/Images/events/mafia_logo.png", name = "Classic mafia", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            events.Add(new EventsView() { logoImg = "/Content/Images/events/salsa_logo.gif", name = "Salsa", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            events.Add(new EventsView() { logoImg = "/Content/Images/events/soccer_logo.png", name = "Soccer", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            events.Add(new EventsView() { logoImg = "/Content/Images/events/vegan_logo.jpg", name = "Vegan club", where = "Kyive, Zhylianska Street", when = "26/03/2015", available = "2 free sits" });
            #endregion
            return View(new MainPageViewModel()
            {
                slider = slider,
                interests = interests,
                events = events,
                groups = groups
            });
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Groups()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }


        public ActionResult Interests()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    return View();
        //}


    }
}