using System;
namespace IsDisco.Models
{
    public class BlacklistModel
    {
        public Track TrackObj { get; set; }

        public BlacklistModel(Track TrackObj)
        {
            this.TrackObj = TrackObj;
        }
    }
}
