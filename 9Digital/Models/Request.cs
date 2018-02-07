using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9Digital.Models
{
    public class Request
    {
        public Show[] Payload { get; set; }
        public string Skip { get; set; }
        public string Take { get; set; }
        public string TotalRecords { get; set; }
    }
}