using System.Collections.Generic;
using System.Threading.Tasks;
using StreetPianos.DataLayer.Core.Models;

namespace StreetPianos.DataLayer.Core
{
    public interface IStreetPianoData
    {
        Task<List<Piano>> GetAllPianosAsync();

        Task<List<Piano>> GetPianosByLocationAsync(double latitude, double longitude, double rangeInKms);

        Task<List<Piano>> GetPianosByLocationAndPageAsync(double latitude, double longitude,
            double rangeInKms, int pageSize, int pageNumber);

        Task<List<Comment>> GetCommentsForPianoAsync(string pianoId, string pianoGroupingId,
            int pageSize, int pageNumber);
    }
}
