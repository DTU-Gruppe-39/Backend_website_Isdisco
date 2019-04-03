using System;
namespace IsDisco.Models
{
    public class Request
    {
        public String ReqId { get; set; }
        public Track1 Track { get; set; }
        public User User { get; set; }
        public DateTime Since { get; set; }
        public int Votes { get; set; }


        public Request(string reqId, Track1 track, User user, DateTime since, int votes)
        {
            this.ReqId = reqId;
            this.Track = track;
            this.User = user;
            this.Since = since;
            this.Votes = votes;
        }
    }
}
