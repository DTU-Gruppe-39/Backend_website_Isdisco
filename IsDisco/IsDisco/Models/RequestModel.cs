using System;
using System.Collections;
using System.Collections.Generic;

namespace IsDisco.Models
{
    public class RequestModel
    {
        public int ReqId { get; set; }
        public TrackModel Track { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public List<int> UpVotes { get; set; }
        public List<UserModel> UpvoteUsers { get; set; }
        public List<int> DownVotes { get; set; }
        public List<UserModel> DownvoteUsers { get; set; }

        public RequestModel(int reqId, TrackModel track, int userId, DateTime timestamp, List<int> downvotes, List<int> upvotes, List<UserModel> upvoteUsers, List<UserModel> downvoteUsers )
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

        public Boolean CompareReq(RequestModel Req)
        {
            if (Track.Compare(Req.Track))
            {
                return true;
            }
            else { return true; }
        }
    }
}
