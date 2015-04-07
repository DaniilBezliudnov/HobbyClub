using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HobbyClub.Web.Models
{
    public class Events
    {
        public string logoImg { get; set; }
        public string name { get; set; }
        public string where { get; set; }
        public string when { get; set; }
        public string available { get; set; }
    }
    public class EventViewModel
    {
        public List<Events> events { get; set; }
       
    }


}