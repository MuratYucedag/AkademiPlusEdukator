using AkademiPlusEdukator.BusinessLayer.Abstract;
using AkademiPlusEdukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categorService;
        public CategoryController(ICategoryService categorService)
        {
            _categorService = categorService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categorService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categorService.TInsert(category);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values = _categorService.TGetByID(id);
            _categorService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _categorService.TUpdate(category);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values=_categorService.TGetByID(id);
            return Ok(values);
        }
    }
}
