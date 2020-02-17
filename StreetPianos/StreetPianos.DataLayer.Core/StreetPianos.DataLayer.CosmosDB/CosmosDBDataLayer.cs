using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StreetPianos.DataLayer.Core;
using StreetPianos.DataLayer.Core.Models;

namespace StreetPianos.DataLayer.CosmosDB
{
    public class CosmosDBDataLayer : IStreetPianoData
    {
        public Task<List<Piano>> GetAllPianosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetCommentsForPianoAsync(string pianoId, string pianoGroupingId, int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Task<List<Piano>> GetPianosByLocationAndPageAsync(double latitude, double longitude, double rangeInKms, int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Task<List<Piano>> GetPianosByLocationAsync(double latitude, double longitude, double rangeInKms)
        {
            throw new NotImplementedException();
        }
    }
}
