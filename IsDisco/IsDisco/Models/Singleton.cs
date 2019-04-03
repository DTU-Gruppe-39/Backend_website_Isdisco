using System;
using System.Collections.Generic;
using System.Threading;

namespace IsDisco.Models
{
    public class Singleton
    {
        private static Singleton instance;
        private static List<User> users = new List<User>();
        private static List<Track> tracks = new List<Track>();
        private static List<Request> requests = new List<Request>();

        //Not sure if we will be using tracks or tracks1
        private List<Track1> tracks1 = new List<Track1>();



        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

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
            tracks.Add(new Track("Test", users, "Baby", "Justin", DateTime.Now, 0, false, 5, false));
            tracks.Add(new Track("Test", users, "Despacito", "Bob", DateTime.Now, 0, false, 5, true));
            tracks.Add(new Track("Test", users, "Gangnam Style", "PSY", DateTime.Now, 0, false, 5, false));
            tracks.Add(new Track("Test", users, "오빤 강남스타일 ", "강남스타일 ", DateTime.Now, 0, false, 5, true));
        }

        public void InitTracks1()
        {
            tracks1.Add(new Track1("Baby", "Justin Bieber", "Test1", 0, false, false));
            tracks1.Add(new Track1("Despacito", "Luis Fonsi", "Test2", 0, false, false));
            tracks1.Add(new Track1("American Idiot", "Green Day", "Test3", 0, false, false));
            tracks1.Add(new Track1("7 Rings", "Ariana Grande", "Test4", 0, false, false));
            tracks1.Add(new Track1("Sucker", "Jonas Brothers", "Test5", 0, false, false));
            tracks1.Add(new Track1("Sunflower", "Post Malone", "Test6", 0, false, false));
            tracks1.Add(new Track1("Shallow", "Lady Gaga", "Test7", 0, false, false));
            tracks1.Add(new Track1("Sweet but Psycho", "Ava Max", "Test8", 0, false, false));
            tracks1.Add(new Track1("Gangnam Style", "Psy", "Test9", 0, false, false));
            tracks1.Add(new Track1("Nede Mette", "Blak", "1Test", 0, false, false));
            tracks1.Add(new Track1("Model", "Gulddreng", "2Test", 0, false, false));
        }

        public void InitRequests()
        {
            Random random = new Random();
            requests.Add(new Request("0", tracks1.Find(x => x.Title.Contains("Baby")), users.Find(y => y.ID.Equals(0)), DateTime.Now.AddSeconds(-10000)));
            requests.Add(new Request("1", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(1)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("2", tracks1.Find(x => x.Title.Contains("American Idiot")), users.Find(y => y.ID.Equals(2)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("3", tracks1.Find(x => x.Title.Contains("Sucker")), users.Find(y => y.ID.Equals(3)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("4", tracks1.Find(x => x.Title.Contains("Sweet but Psycho")), users.Find(y => y.ID.Equals(4)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("5", tracks1.Find(x => x.Title.Contains("Model")), users.Find(y => y.ID.Equals(5)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("6", tracks1.Find(x => x.Title.Contains("Nede Mette")), users.Find(y => y.ID.Equals(6)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("7", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(7)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("8", tracks1.Find(x => x.Title.Contains("Baby")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("9", tracks1.Find(x => x.Title.Contains("Gangnam Style")), users.Find(y => y.ID.Equals(9)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("10", tracks1.Find(x => x.Title.Contains("Sunflower")), users.Find(y => y.ID.Equals(10)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("11", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(11)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("12", tracks1.Find(x => x.Title.Contains("Baby")), users.Find(y => y.ID.Equals(0)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("13", tracks1.Find(x => x.Title.Contains("7 Rings")), users.Find(y => y.ID.Equals(2)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("14", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(6)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("15", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("16", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("17", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("18", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("19", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("20", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("21", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("22", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("23", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("24", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("25", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("26", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("27", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("28", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("29", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("30", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));
            requests.Add(new Request("31", tracks1.Find(x => x.Title.Contains("Despacito")), users.Find(y => y.ID.Equals(8)), DateTime.Now.AddSeconds(-random.Next(1000))));



        }


        public List<User> GetUsers()
        {
            return users;
        }

        public List<Track> GetTracks()
        {
            return tracks;
        }

        public List<Track1> GetTrack1s()
        {
            return tracks1;
        }

        public List<Request> GetRequests()
        {
            return requests;
        }
    }
}
