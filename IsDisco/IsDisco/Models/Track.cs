using System;
namespace IsDisco.Models
{
    public class Track
    {

        public string Title { get; set; }
        public string Artist { get; set; }
        public string Track_id { get; set; }
        public string Spotify_webplayer_link { get; set; }

        //public DateTime Since { get; set; }
        //public int Cd_timer { get; set; }
        //public Boolean Cooldown { get; set; }
        //public Boolean Blacklist { get; set; }

        public Track(string title, string artist, string track_id, string Spotify_webplayer_link)
        {
            this.Title = title;
            this.Artist = artist;
            this.Track_id = track_id;
            this.Spotify_webplayer_link = Spotify_webplayer_link;
            //this.Cd_timer = cd_timer;
            //this.Cooldown = cooldown;
            //this.Blacklist = blacklist;
        }

        public Boolean Compare(Track track)
        {
            if (string.Compare(track.Track_id, Track_id) == 0 )
            {
                return true;
            }
            else { return false; }
        }
    }
}
