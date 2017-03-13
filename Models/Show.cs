using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OmaApi.Controllers
{
    public class Show
    {
        public int ID { get; set; }
        public int TheatreID { get; set; }
        public string Title { get; set; }
        public DateTime dttmShowStart { get; set; }
        public int LengthInMinutes { get; set; }
        public string Rating { get; set; }
        public string TheatreAndAuditorium { get; set; }
        public string Genres { get; set; }
    }
}