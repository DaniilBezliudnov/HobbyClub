using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HobbyClub.Web.Models
{
    public class SliderView {
        public string img { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
    public class GroupsView {
        public string logoImg { get; set; }
        public string name { get; set; }
        public string description { get; set; }      
    }
    public class EventsView {
        public string logoImg { get; set; }
        public string name { get; set; }
        public string where { get; set; }
        public string when { get; set; }
        public string available { get; set; }
    }
    public class InterestsView {
        public string img { get; set; }
        public string name { get; set; }
        public string previewImg { get; set; }
    }    

    public class MainPageViewModel
    {
        public List<SliderView> slider { get; set; }
        public List<InterestsView> interests { get; set; }
        public List<EventsView> events { get; set; }
        public List<GroupsView> groups { get; set; }
    }
}