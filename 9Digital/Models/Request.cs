using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace _9Digital.Models
{
    //class to model the received Json from the client
    // contains list of shows and aggregate details
    public class Request
    {
        public Show[] Payload { get; set; }
        public string Skip { get; set; }
        public string Take { get; set; }
        public string TotalRecords { get; set; }
    }
}