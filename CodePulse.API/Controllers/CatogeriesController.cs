using CodePulse.API.Data;
using CodePulse.API.Model.Domains;
using CodePulse.API.Model.DTO;
using CodePulse.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatogeriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CatogeriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task <IActionResult> CreateCategories(CreateCategoriesRequestDto request)
        {
            var catrgory = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };           
            await categoryRepository.CreateAsync(catrgory);

            var response = new CategoryDto
            {
                Id = catrgory.Id,
                Name = catrgory.Name,
                UrlHandle = catrgory.UrlHandle
            };
            return Ok (response);
        } 
    }
}
