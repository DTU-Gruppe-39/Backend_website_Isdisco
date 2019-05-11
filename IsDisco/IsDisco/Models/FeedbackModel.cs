using System;
using System.Collections;

namespace IsDisco.Models
{
    public class FeedbackModel
    {
        public User user { get; set; }
        public String tag { get; set;}
        public String message { get; set;}
        public int id {get; set;}


        public FeedbackModel(User user, String tag, String message, int id)
        {
            this.user = user;
            this.tag = tag;
            this.message = message;
            this.id = id;
        }
    }
}