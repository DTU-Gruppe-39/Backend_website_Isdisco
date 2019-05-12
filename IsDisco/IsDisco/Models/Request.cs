using System;
using System.Collections;
using System.Collections.Generic;

namespace IsDisco.Models
{
    public class Request
    {
        public int ReqId { get; set; }
        public Track Track { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public List<int> UpVotes { get; set; }
        public List<User> UpvoteUsers { get; set; }
        public List<int> DownVotes { get; set; }
        public List<User> DownvoteUsers { get; set; }

        public Request(int reqId, Track track, int userId, DateTime timestamp, List<int> downvotes, List<int> upvotes, List<User> upvoteUsers, List<User> downvoteUsers )
        {
            this.ReqId = reqId;
            this.Track = track;
            this.UserId = userId;
            this.Timestamp = timestamp;
            this.UpVotes = upvotes;
            this.DownVotes = downvotes;
            this.UpvoteUsers = upvoteUsers;
            this.DownvoteUsers = downvoteUsers;
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
