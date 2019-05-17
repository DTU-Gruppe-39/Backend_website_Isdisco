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
    public class FeedbackController
    {

        public IList GetFeedback()
        {
            List<FeedbackModel> Feedbacks = new List<FeedbackModel>();

            var webclient = new WebClient();
            String Reqresp = webclient.DownloadString("https://isdisco.azurewebsites.net/api/feedback/all");
            var JFeedback = JArray.Parse(Reqresp);


            for (int i = 0; i < JFeedback.Count; i++)
            {
                var userId = Convert.ToInt32(JFeedback[i]["user"]["id"].ToString());
                var userName = JFeedback[i]["user"]["fullname"].ToString();
                var userVIP = JFeedback[i]["user"]["vip"].ToString();
                var tag = JFeedback[i]["tag"].ToString();
                var message = JFeedback[i]["message"].ToString();
                var id = Convert.ToInt32(JFeedback[i]["id"].ToString());

                UserModel user = new UserModel(userName, userId);
                FeedbackModel Feeds = new FeedbackModel(user, tag, message, id);
                Feedbacks.Add(Feeds);
            }

            return Feedbacks;
        }

    }
}
