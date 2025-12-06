using CliniqueBackend.Data;
using CliniqueBackend.Dtos;

namespace CliniqueBackend.Services;

public class BlogPostService: IBlogPost
{
    private readonly AppDbContext _context;
    public BlogPostService(AppDbContext context)
    {
        this._context = context;
    }

}