using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_API.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [Route("page")]
        [HttpGet]
        public async Task<Page<Post>> GetPosts (int pageIndex, string tag)
        {
            return await _blogService.Get
        }
    }
}
