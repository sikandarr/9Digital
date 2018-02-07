using _9Digital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _9Digital.Controllers
{
    public class ShowsController : ApiController
    {
        public IHttpActionResult PostShow(Request Payload)
        {
            try
            {
                Payload.Payload = Payload.Payload.Where(show => show.Drm == true && show.EpisodeCount > 0).ToArray();
                return Json(new ResponseModel(Show.GetResponseShows(Payload.Payload)));
            }
            catch(ArgumentNullException)
            {
                return BadRequest("Could not decode request: JSON parsing failed");
            }
        }
    }
}
