namespace Blog_API.Controllers
{
    public interface IBlogService
    {
        Task<Page<PostLiteViewModel>> GetPosts(int pageIndex, string tag);
    }
}