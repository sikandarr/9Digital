using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9Digital.Models
{
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