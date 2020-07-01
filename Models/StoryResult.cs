using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.Models
{
    public class StoryResult
    {
        public StoryResult(string title, string uri, string postedBy, string time, int score, int commentCount)
        {
            this.title = title;
            this.uri = uri;
            this.postedBy = postedBy;
            this.time = time;
            this.score = score;
            this.commentCount = commentCount;
        }

        public string title { get; set; }
        public string uri { get; set; }
        public string postedBy { get; set; }
        public string time { get; set; }
        public int score { get; set; }
        public int commentCount { get; set; }
    }
}
