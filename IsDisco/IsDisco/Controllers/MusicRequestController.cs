using IsDisco.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IsDisco.Controllers
{
    public class MusicRequestController
    {

        public IList GetMusicRequest(Boolean isLive)
        {
            String Reqresp;
            var webclient = new WebClient();
            if (isLive)
            {
                 Reqresp = webclient.DownloadString("https://isdisco.azurewebsites.net/api/musicrequest/live");
            }
            else
            {
                 Reqresp = webclient.DownloadString("https://isdisco.azurewebsites.net/api/musicrequest");
            }
            var JRequests = JArray.Parse(Reqresp);
            List<RequestModel> requests = new List<RequestModel>();

            // Makes a List<Request> from the Json data from the backend
            for (int i = 0; i < JRequests.Count; i++)
            {
                List<int> downvotes = new List<int>();
                List<int> upvotes = new List<int>();
                List<UserModel> downvoteUsers = new List<UserModel>();
                List<UserModel> upvoteUsers = new List<UserModel>();
                var userId = Convert.ToInt32(JRequests[i]["userId"].ToString());
                var ReqId = Convert.ToInt32(JRequests[i]["id"].ToString());
                var trackId = JRequests[i]["track"]["id"].ToString();
                var downNum = JRequests[i]["downvotes"].Count();
                for (int j = 0; j < downNum; j++)
                {
                    downvotes.Add(Convert.ToInt32(JRequests[i]["downvotes"][j].ToString()));
                }
                var upNum = JRequests[i]["upvotes"].Count();
                for (int j = 0; j < upNum; j++)
                {
                    upvotes.Add(Convert.ToInt32(JRequests[i]["upvotes"][j].ToString()));
                }
                var downUserNum = JRequests[i]["downvoteUsers"].Count();
                for (int j = 0; j < downUserNum; j++)
                {
                    var downUserId = Convert.ToInt32(JRequests[i]["downvoteUsers"][j]["id"].ToString());
                    var downUserName = JRequests[i]["downvoteUsers"][j]["fullname"].ToString();
                    UserModel downUsr = new UserModel(downUserName, downUserId);
                    downvoteUsers.Add(downUsr);
                }
                var upUserNum = JRequests[i]["upvoteUsers"].Count();
                for (int j = 0; j < upUserNum; j++)
                {
                    var upUserId = Convert.ToInt32(JRequests[i]["upvoteUsers"][j]["id"].ToString());
                    var upUserName = JRequests[i]["upvoteUsers"][j]["fullname"].ToString();
                    UserModel upUsr = new UserModel(upUserName, upUserId);
                    upvoteUsers.Add(upUsr);
                }
                var thesongName = JRequests[i]["track"]["songName"].ToString();
                var artistName = JRequests[i]["track"]["artistName"].ToString();
                var webplayerLink = JRequests[i]["track"]["webplayerLink"].ToString();
                var date = Convert.ToDateTime(JRequests[i]["timestamp"].ToString());
                TrackModel track = new TrackModel(thesongName, artistName, trackId, webplayerLink);
                RequestModel Reqs = new RequestModel(ReqId, track, userId, date, downvotes, upvotes, upvoteUsers, downvoteUsers);
                requests.Add(Reqs);
            }
            // Sorts the list so the one with most upvotes - downvotes is at the top
            if (!isLive)
            {
            //requests.Sort((x, y) => -(x.UpVotes.Count - x.DownVotes.Count).CompareTo((y.UpVotes.Count - y.DownVotes.Count)));
            requests.Sort((x, y) => (x.UpVotes.Count - x.DownVotes.Count).CompareTo((y.UpVotes.Count - y.DownVotes.Count)));
            requests.Reverse();
            }
            else
            {
                // requests.Sort((x, y) => -x.Timestamp.CompareTo(y.Timestamp));
                requests.Sort((x, y) => x.Timestamp.CompareTo(y.Timestamp));
                requests.Reverse();
            }
            return requests;
        }


    }
}
