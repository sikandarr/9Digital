using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9Digital.Models
{
    //this class models the properties of the show
    public class Show
    {
        public String Country { get; set; }
        public String Description { get; set; }
        public bool Drm { get; set; }
        public int EpisodeCount { get; set; }
        public String Genre { get; set; }
        public String Language { get; set; }
        public NextEpisode NextEpisode { get; set; }
        public String PrimaryColour { get; set; }
        public Season[] Seasons { get; set; }
        public String TvChannel { get; set; }
        public Image Image { get; set; }
        public String Slug { get; set; }
        public String Title { get; set; }

        public ResponseShow GetResponseShow()
        {
            return new ResponseShow(Image.ShowImage, Slug, Title);
        }

        //creates an array of ResponseShow from the given array of Shows
        public static ResponseShow[] GetResponseShows(Show[] Shows)
        {
            ResponseShow[] ResponseShows = new ResponseShow[Shows.Length];
            for (int i = 0; i < Shows.Length; i++)
                ResponseShows[i] = Shows[i].GetResponseShow();

            return ResponseShows;
        }
    }
}