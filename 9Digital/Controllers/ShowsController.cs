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
        public HttpResponseMessage PostShow(Request Payload)
        {
            try
            {
                //Payload.Payload is the list of shows we've received from the client
                // filter the shows as per the criterial i.e. where the show's Drm is true and the episode count > 0
                Payload.Payload = Payload.Payload.Where(show => show.Drm == true && show.EpisodeCount > 0).ToArray();

                // send the filtered list of shows to Show's static method GetResponseShows
                // and create a new ResponseModel from the returned list of ResponseShows
                // send the ResponseModel object to the client with the status 200
                return Request.CreateResponse(HttpStatusCode.OK, new ResponseModel(Show.GetResponseShows(Payload.Payload)));
            }
            catch (Exception)
            {
                // probably the incoming Json could not be parsed
                // send the client a simple annonymus object with error property
                // with status 400
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Error = "Could not decode request: JSON parsing failed" });
            }
        }
    }
}
