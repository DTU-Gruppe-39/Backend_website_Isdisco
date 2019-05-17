using System;
namespace IsDisco.Models
{
    public class BlacklistModel
    {
        public TrackModel TrackObj { get; set; }

        public BlacklistModel(TrackModel TrackObj)
        {
            this.TrackObj = TrackObj;
        }
    }
}
