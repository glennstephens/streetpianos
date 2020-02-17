namespace StreetPianos.DataLayer.Core.Models
{
    public class Comment : BaseItem
    {
        public SocialMediaType UserMediaType { get; set; }
        public string Username { get; set; }
        public string UserComment { get; set; }
        public string PianoId { get; set; }
        public string PianoGroupingId { get; set; }
    }
}
