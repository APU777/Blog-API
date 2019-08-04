using System;

namespace Models
{
    public class Post
    {
        public string Body { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Header { get; set; }
        public string PostId { get; set; }
        public string Tags { get; set; }
    }
}
