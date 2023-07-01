using System;

namespace ConsoleApp1
{
    public class Post
    {
        private string _title { get; set; }
        private string _description { get; set; }
        private int _votes { get; set; } = 0;
        private DateTime _created { get; set; }

        public string title
        {
            get
            {
                return _title;
            }
        }
        public string description
        {
            get
            {
                return _description;
            }
        }

        public int numberOfVotes
        {
            get
            {
                return _votes;
            }
        }

        public DateTime created
        {
            get
            {
                return _created;
            }
        }

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _created = DateTime.Now;
        }

        public void UpVoting()
        {
            _votes++;
        }

        public void DownVoting()
        {
            _votes--;
        }
    }
}