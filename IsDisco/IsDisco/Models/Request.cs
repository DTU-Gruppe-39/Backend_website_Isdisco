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


        public Request(string reqId, Track1 track, User user, DateTime since)
        {
            this.ReqId = reqId;
            this.Track = track;
            this.User = user;
            this.Since = since;
            this.Votes = 1;
        }

        public Boolean CompareReq(Request Req)
        {
            if (Track.Compare(Req.Track))
            {
                return true;
            }
            else { return true; }
        }
    }
}
