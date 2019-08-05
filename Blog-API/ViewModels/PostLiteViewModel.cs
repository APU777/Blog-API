using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_API.ViewModels
{
    public class PostLiteViewModel
    {
        public int PostId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public int CommentCount { get; set; }
    }
}