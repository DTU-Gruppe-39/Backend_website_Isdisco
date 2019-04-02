using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsDisco.Models
{
    public class Track
    {
        public List<User> Users { get; set; }
        public string Song { get; set; }
        public string Author { get; set; }
        public string Id_link { get; set; }
        public DateTime Since { get; set; }
        public int Votes { get; set; }
        public int Cd_timer { get; set; }
        public Boolean Cooldown { get; set; }
        public Boolean Blacklist { get; set; }

        public Track(string id_link, List<User> users, string song, string author,
        DateTime since, int votes, Boolean cooldown, int cd_timer, Boolean blacklist)
        {
            this.Id_link = id_link;
            this.Users = users;
            this.Song = song;
            this.Author = author;
            this.Since = since;
            this.Votes = votes;
            this.Cooldown = cooldown;
            this.Cd_timer = cd_timer;
            this.Blacklist = blacklist;
        }
    }
}