using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9Digital.Models
{
    // the actual response that is sent to the client 
    // containing the list of ResponseShows
    public class ResponseModel
    {
        public ResponseShow[] Response { get; set; }

        //set the ResponseShow[]
        public ResponseModel(IEnumerable<ResponseShow> response)
        {
            this.Response = response.ToArray();
        }
    }
}