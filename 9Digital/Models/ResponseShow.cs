using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9Digital.Models
{
    // The response that is sent to the client
    // note that this class is needed (rather than sending required properties from the Show with [JsonIgnore])
    // because response should contain
    // the link to Show's image as a String rather than an object
    public class ResponseShow
    {
        public string Image { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }

        public ResponseShow(string image, string slug, string title)
        {
            Image = image;
            Slug = slug;
            Title = title;
        }
    }
}