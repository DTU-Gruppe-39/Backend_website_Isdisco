using System;
using System.Collections.Generic;
using System.Threading;

namespace IsDisco.Models
{
    public class Singleton
    {
        private static Singleton instance;
        private static List<User> users = new List<User>();
        private static List<Request> requests = new List<Request>();
        private List<Track> tracks = new List<Track>();
        private List<BlacklistModel> blacklist = new List<BlacklistModel>();

        private List<FeedbackModel> feedback = new List<FeedbackModel>();
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        /*
        public void InitUsers()
        {
            users.Add(new User("Mark", 0));
            users.Add(new User("Thomas", 1));
            users.Add(new User("Rasmus", 2));
            users.Add(new User("Søren", 3));
            users.Add(new User("Magnus", 4));
            users.Add(new User("Patrick", 5));
            users.Add(new User("Marcus", 6));
            users.Add(new User("Mark2", 7));
            users.Add(new User("Thomas2", 8));
            users.Add(new User("Rasmus2", 9));
            users.Add(new User("Søren2", 10));
            users.Add(new User("Magnus2", 11));
            users.Add(new User("Patrick2", 12));
            users.Add(new User("Marcus2", 13));
            users[0].VIP = true;
            users[1].VIP = true;
            users[2].VIP = true;
            users[3].VIP = true;
            users[4].VIP = true;
            users[5].VIP = true;
            users[6].VIP = true;
            users[7].VIP = true;
            users[8].VIP = true;
            users[9].VIP = true;
            users[10].VIP = true;
            users[11].VIP = true;
            users[12].VIP = true;
            users[13].VIP = true;
        }

        public void InitTracks()
        {
            tracks.Add(new Track("Baby", "Justin Bieber", "Test1", "https://open.spotify.com/track/6epn3r7S14KUqlReYr77hA?si=lz0CGPlZTtiG1ODMTupE-g"));
            tracks.Add(new Track("Despacito", "Luis Fonsi", "Test2", "https://open.spotify.com/track/6rPO02ozF3bM7NnOV4h6s2?si=tUXS9VezQFWEU4vysVo8Qw"));
            tracks.Add(new Track("American Idiot", "Green Day", "Test3", "https://open.spotify.com/track/6nTiIhLmQ3FWhvrGafw2zj?si=nk4kX7nCT3-_3tMFET5dMg"));
            tracks.Add(new Track("7 Rings", "Ariana Grande", "Test4", "https://open.spotify.com/track/14msK75pk3pA33pzPVNtBF?si=7dZBYiWgR0aSuHWu8Uo-mw"));
            tracks.Add(new Track("Sucker", "Jonas Brothers", "Test5", "https://open.spotify.com/track/4y3OI86AEP6PQoDE6olYhO?si=Iei8W88NRj-wO9XcyHTBbQ"));
            tracks.Add(new Track("Sunflower", "Post Malone", "Test6", "https://open.spotify.com/track/3KkXRkHbMCARz0aVfEt68P?si=YweS1cqlS0C_BJ_H14-TUw"));
            tracks.Add(new Track("Shallow", "Lady Gaga", "Test7", "https://open.spotify.com/track/2VxeLyX666F8uXCJ0dZF8B?si=XU18v7syTUuHhx8h115x4w"));
            tracks.Add(new Track("Sweet but Psycho", "Ava Max", "Test8", "https://open.spotify.com/track/25sgk305KZfyuqVBQIahim?si=YIPBt3VESRaqIyzm60w_kw"));
            tracks.Add(new Track("Gangnam Style", "Psy", "Test9", "https://open.spotify.com/track/03UrZgTINDqvnUMbbIMhql?si=gtaXMnlsSIm0Klhyvo_yAQ"));
            tracks.Add(new Track("Nede Mette", "Blak", "1Test", "https://open.spotify.com/track/2gFaHRqjAE5ZNNnGr9eYG4?si=Oo4fJD0ZSsq45tFeVvApLw"));
            tracks.Add(new Track("Model", "Gulddreng", "2Test", "https://open.spotify.com/track/7Gf2vkf59IaWPu3Kb5Tdmx?si=dNnR67GKRzeWYyxK7JnqxQ"));
        }
        public void InitBlacklist()
        {
            //blacklist.Add(new BlacklistModel(tracks[2]));
        }

        public void InitRequests()
        {
            Random random = new Random();
            requests.Add(new Request(0, tracks.Find(x => x.Title.Contains("Baby")), users.Find(y => y.ID==0).ID, DateTime.Now.AddSeconds(-10000)));
            requests.Add(new Request(1, tracks.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID ==1).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(2, tracks.Find(x => x.Title.Contains("American Idiot")), users.Find(y => y.ID == 2).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(3, tracks.Find(x => x.Title.Contains("Sucker")), users.Find(y => y.ID == 3).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(4, tracks.Find(x => x.Title.Contains("Sweet but Psycho")), users.Find(y => y.ID == 4).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(5, tracks.Find(x => x.Title.Contains("Model")), users.Find(y => y.ID == 5).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(6, tracks.Find(x => x.Title.Contains("Nede Mette")), users.Find(y => y.ID == 6).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(7, tracks.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID == 7).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(8, tracks.Find(x => x.Title.Contains("Baby")), users.Find(y => y.ID == 8).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(9, tracks.Find(x => x.Title.Contains("Gangnam Style")), users.Find(y => y.ID == 9).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(10, tracks.Find(x => x.Title.Contains("Sunflower")), users.Find(y => y.ID == 10).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(11, tracks.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID == 11).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(12, tracks.Find(x => x.Title.Contains("Baby")), users.Find(y => y.ID == 0).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(13, tracks.Find(x => x.Title.Contains("7 Rings")), users.Find(y => y.ID ==2 ).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(14, tracks.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID == 6).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request(15, tracks.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID == 8).ID, DateTime.Now.AddSeconds(-random.Next(1000))));
       



        }


        public List<User> GetUsers()
        {
            return users;
        }

        public List<Track> GetTracks()
        {
            return tracks;
        }

        public List<Request> GetRequests()
        {
            return requests;
        }

        public List<BlacklistModel> GetBlacklist()
        {
            return blacklist;
        }

                public List<FeedbackModel> GetFeedback()
        {
            return feedback;
        }
    }
    */
    }
}
