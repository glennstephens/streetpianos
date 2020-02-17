using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StreetPianos.DataLayer.Core.Models;

namespace StreetPianos.DataLayer.Core
{
    public class MockStreetPianoData : IStreetPianoData
    {
        Piano childrensHospital = new Piano()
        {
            Id = "1",
            GroupingId = "testdata",
            Country = "Australia",
            City = "Brisbane",
            PianoName = "Brisbane Children's Hospital",
            StateOrProvince = "Queensland",
            Suburb = "South Brisbane",
            AdditionalDirections = "You'll find it just outside the food court on the bottom level",
            StreetAddress = "501 Stanley Street",
            Latitude = 47.663480,
            Longitude = -122.281970
        };

        Comment childrensHospitalComment = new Comment()
        {
            Id = "comment1",
            GroupingId = "testdata",
            PianoId = "1",
            PianoGroupingId = "testdata",
            Username = "glenntstephens",
            UserMediaType = SocialMediaType.Twitter,
            UserComment = "This is a nice stripey piano"
        };

        List<Piano> GetMockData()
        {
            return new List<Piano>(new Piano[] { childrensHospital });
        }

        public async Task<List<Piano>> GetAllPianosAsync()
        {
            return GetMockData();
        }

        public async Task<List<Comment>> GetCommentsForPianoAsync(string pianoId, string pianoGroupingId, int pageSize, int pageNumber)
        {
            return new List<Comment>(new[] { childrensHospitalComment });
        }

        public async Task<List<Piano>> GetPianosByLocationAndPageAsync(double latitude, double longitude, double rangeInKms, int pageSize, int pageNumber)
        {
            return GetMockData();
        }

        public async Task<List<Piano>> GetPianosByLocationAsync(double latitude, double longitude, double rangeInKms)
        {
            return GetMockData();
        }
    }
}
