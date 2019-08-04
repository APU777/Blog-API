using System;

namespace Models
{
    public class Comments
    {
        public string Author { get; set; }
        public string Body { get; set; }
        public string CommentId { get; set; }
        public DateTime CreatDate { get; set; }
        public string PostId { get; set; }
    }
}
