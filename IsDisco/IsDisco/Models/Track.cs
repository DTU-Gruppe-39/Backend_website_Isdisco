using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsDisco.Models
{
    public class Track
    {
        public List<User> users { get; set; }
        public string song { get; set; }
        public string author { get; set; }
        public string id_link { get; set; }
        public DateTime since { get; set; }
        public int votes { get; set; }
        public int cd_timer { get; set; }
        public Boolean cooldown { get; set; }
        public Boolean blacklist { get; set; }

        public Track(string id_link, List<User> users, string song, string author,
        DateTime since, int votes, Boolean cooldown, int cd_timer, Boolean blacklist)
        {
            this.id_link = id_link;
            this.users = users;
            this.song = song;
            this.author = author;
            this.since = since;
            this.votes = votes;
            this.cooldown = cooldown;
            this.cd_timer = cd_timer;
            this.blacklist = blacklist;
        }
    }
}