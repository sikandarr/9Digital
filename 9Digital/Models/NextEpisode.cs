using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9Digital.Models
{
    // the class to model the details concerning a show's
    // NextEpisode including the channel & the coming date 
    // it is to be aired
    // Show class conatains an object of type NextEpisode
    public class NextEpisode
    {
        public string Channel { get; set; }
        public string ChannelLogo { get; set; }
        public DateTime ? Date { get; set; }
        public string Html { get; set; }
        public string Url { get; set; }
    }
}