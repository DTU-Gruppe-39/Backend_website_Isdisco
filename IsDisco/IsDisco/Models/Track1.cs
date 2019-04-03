using System;
namespace IsDisco.Models
{
    public class Track1
    {

        public string Title { get; set; }
        public string Artist { get; set; }
        public string Id_link { get; set; }
        public DateTime Since { get; set; }
        public int Cd_timer { get; set; }
        public Boolean Cooldown { get; set; }
        public Boolean Blacklist { get; set; }

        public Track1(string title, string artist, string id_link,
             int cd_timer, Boolean cooldown, Boolean blacklist)
        {
            this.Title = title;
            this.Artist = artist;
            this.Id_link = id_link;
            this.Cd_timer = cd_timer;
            this.Cooldown = cooldown;
            this.Blacklist = blacklist;
        }

        public Boolean Compare(Track1 track)
        {
            if (string.Compare(track.Id_link, Id_link) == 0 )
            {
                return true;
            }
            else { return false; }
        }
    }
}
