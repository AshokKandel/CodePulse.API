using CodePulse.API.Model.Domains;

namespace CodePulse.API.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
