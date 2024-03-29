﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public interface IBlogRepository
    {
        Task<Page<Post>> GetPosts(int index, int pageSize, string tag = null);
        Task<Post> GetPost(int postId);
        Task AddComment(Comment comment);
        Task<List<string>> GetAllTagNames();
        Task AddPost(Post post);
        Task DeletePost(int postId);
        Task DeleteComment(int commentId);
    }
}
