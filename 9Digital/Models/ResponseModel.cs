using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9Digital.Models
{
    public class ResponseModel
    {
        public ResponseShow[] Response { get; set; }

        public ResponseModel(IEnumerable<ResponseShow> response)
        {
            this.Response = response.ToArray();
        }
    }
}