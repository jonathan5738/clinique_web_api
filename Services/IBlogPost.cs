using CliniqueBackend.Dtos;
using CliniqueBackend.Models;

namespace CliniqueBackend.Services;

public interface IBlogPost
{
    public Task<List<BlogPostPagination>> FindAll(int page, int pageSize);
    public Task<BlogPost> FindOne(int id);
    public Task Create(BlogPostDTO data);
    public Task Update(BlogPost post, BlogPostDTO data);

    public Task Delete(BlogPost post);
}