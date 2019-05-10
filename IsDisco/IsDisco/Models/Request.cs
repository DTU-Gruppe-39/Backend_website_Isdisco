using System;
using System.Collections;

namespace IsDisco.Models
{
    public class Request
    {
        public int ReqId { get; set; }
        public Track Track { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public ArrayList UpVotes { get; set; }
        public int DownVotes { get; set; }


        public Request(int reqId, Track track, int user, DateTime timestamp )
        {
            this.ReqId = reqId;
            this.Track = track;
            this.UserId = user;
            this.Timestamp = timestamp;
            this.UpVotes = new ArrayList();
            UpVotes.Add(reqId);
            this.DownVotes = 0;
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
