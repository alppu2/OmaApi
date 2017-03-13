using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OmaApi.Controllers
{
    public class TheatreController : ApiController
    {
        // kovakoodataan oliolistaan teatterien arvot
        TheatreArea[] theatres = new TheatreArea[] {
            new TheatreArea { ID = 1, Name = "Omateatteri 1" },
            new TheatreArea { ID = 2, Name = "Omateatteri 2" },
            new TheatreArea { ID = 3, Name = "Omateatteri 3" }
        };

        // palauttaa kaikki teatterit
        public IEnumerable<TheatreArea> GetAllTheatres()
        {
            return theatres;
        }

        // palauttaa teatterin id:n perusteella
        public IHttpActionResult GetTheatre(int id)
        {
            var theatre = theatres.FirstOrDefault((t) => t.ID == id);
            if (theatre == null)
            {
                return NotFound();
            }
            return Ok(theatre);
        }
    }
}
