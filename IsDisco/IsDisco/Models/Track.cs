using System;
using System.Collections;
using System.Collections.Generic;

namespace IsDisco.Models
{
    public class Track
    {

        private List<User> users { get; set; }
        private String song { get; set; }
        private String author { get; set; }
        private String id_link { get; set; }
        private DateTime since { get; set; }
        private int votes { get; set; }
        private int cd_timer { get; set; }
        private Boolean cooldown { get; set; }
        private Boolean blacklist { get; set; }

        public Track(String id_link, List<User> users, String song, String author,
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