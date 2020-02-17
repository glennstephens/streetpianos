using System;
using System.Collections.Generic;

namespace StreetPianos.DataLayer.Core.Models
{
    public class Piano : BaseItem
    {
        public Piano()
        {
        }

        public string PianoName { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }

        public string AdditionalDirections { get; set; }

        public List<string> ImageUris { get; set; }

        public List<SocialMediaLink> SocialMediaLinks { get; set; }
    }
}
