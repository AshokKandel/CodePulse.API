using CodePulse.API.Data;
using CodePulse.API.Model.Domains;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Repositories
{
    public class Implementation : ICategoryRepository
    {
        private readonly ApplicationDbContex dbContex;

        public Implementation(ApplicationDbContex dbContex)
        {
            this.dbContex = dbContex;
        }
        public async Task<Category> CreateAsync (Category category)
        {
            await dbContex.Category.AddAsync(category);
            await dbContex.SaveChangesAsync();

            return category;
        }
    }
}
