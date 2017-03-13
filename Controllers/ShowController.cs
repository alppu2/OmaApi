using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OmaApi.Controllers
{
    public class ShowController : ApiController
    {
        // kovakoodataan oliolistaan esitysten arvot
        Show[] shows = new Show[] {
            new Show { ID = 1, TheatreID = 1, Title = "Elokuva1", dttmShowStart = new DateTime(2017, 3, 17, 17, 00, 00), LengthInMinutes = 95, Rating = "S", TheatreAndAuditorium = "Omateatteri 1", Genres = "Perhe-elokuva, Animaatio"},
            new Show { ID = 2, TheatreID = 2,Title = "Elokuva1", dttmShowStart = new DateTime(2017, 3, 17, 17, 30, 00), LengthInMinutes = 95, Rating = "S", TheatreAndAuditorium = "Omateatteri 2", Genres = "Perhe-elokuva, Animaatio"},
            new Show { ID = 3, TheatreID = 3,Title = "Elokuva1", dttmShowStart = new DateTime(2017, 3, 17, 17, 00, 00), LengthInMinutes = 95, Rating = "S", TheatreAndAuditorium = "Omateatteri 3", Genres = "Perhe-elokuva, Animaatio"},

            new Show { ID = 4, TheatreID = 2,Title = "Elokuva2", dttmShowStart = new DateTime(2017, 3, 17, 20, 30, 00), LengthInMinutes = 117, Rating = "16", TheatreAndAuditorium = "Omateatteri 2", Genres = "Draama"},
            new Show { ID = 5, TheatreID = 3,Title = "Elokuva2", dttmShowStart = new DateTime(2017, 3, 17, 20, 00, 00), LengthInMinutes = 117, Rating = "16", TheatreAndAuditorium = "Omateatteri 3", Genres = "Draama"},

            new Show { ID = 6, TheatreID = 1,Title = "Elokuva3", dttmShowStart = new DateTime(2017, 3, 18, 19, 45, 00), LengthInMinutes = 130, Rating = "7", TheatreAndAuditorium = "Omateatteri 1", Genres = "Dokumentti"},
            new Show { ID = 7, TheatreID = 2,Title = "Elokuva3", dttmShowStart = new DateTime(2017, 3, 18, 19, 45, 00), LengthInMinutes = 130, Rating = "7", TheatreAndAuditorium = "Omateatteri 2", Genres = "Dokumentti"},
            new Show { ID = 8, TheatreID = 3,Title = "Elokuva3", dttmShowStart = new DateTime(2017, 3, 18, 19, 00, 00), LengthInMinutes = 130, Rating = "7", TheatreAndAuditorium = "Omateatteri 3", Genres = "Dokumentti"},

            new Show { ID = 9, TheatreID = 1,Title = "Elokuva4", dttmShowStart = new DateTime(2017, 3, 17, 21, 30, 00), LengthInMinutes = 121, Rating = "18", TheatreAndAuditorium = "Omateatteri 1", Genres = "Action"},
            new Show { ID = 10, TheatreID = 2,Title = "Elokuva4", dttmShowStart = new DateTime(2017, 3, 17, 21, 00, 00), LengthInMinutes = 121, Rating = "18", TheatreAndAuditorium = "Omateatteri 2", Genres = "Action"},
            new Show { ID = 11, TheatreID = 2,Title = "Elokuva4", dttmShowStart = new DateTime(2017, 3, 18, 21, 00, 00), LengthInMinutes = 121, Rating = "18", TheatreAndAuditorium = "Omateatteri 2", Genres = "Action"},
            new Show { ID = 12, TheatreID = 3,Title = "Elokuva4", dttmShowStart = new DateTime(2017, 3, 18, 21, 30, 00), LengthInMinutes = 121, Rating = "18", TheatreAndAuditorium = "Omateatteri 3", Genres = "Action"},
        };

        // palauttaa kaikki esitykset
        public IEnumerable<Show> GetAllShows()
        {
            return shows;
        }

        // palauttaa esityksen teatterin id:n ja päivän perusteella
        public IHttpActionResult GetShow(int id, DateTime date)
        {
            var show = shows.FirstOrDefault((s) => s.TheatreID == id && s.dttmShowStart.Date == date);
            if (show == null)
            {
                return NotFound();
            }
            return Ok(show);
        }
    }
}
