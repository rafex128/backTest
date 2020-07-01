using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest
{
    public class Story
    {
        public Story(string by, int descendants, int id, int[] kids, int score, long time, string title, string type, string url)
        {
            By = by;
            Descendants = descendants;
            Id = id;
            Kids = kids;
            Score = score;
            Time = time;
            Title = title;
            Type = type;
            Url = url;
        }

        public string By { get; set; }
        public int Descendants { get; set; }
        public int Id { get; set; }
        public int[] Kids { get; set; }
        public int Score { get; set; }
        public long Time { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }
}
