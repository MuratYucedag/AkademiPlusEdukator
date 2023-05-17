using AkademiPlusEdukator.Api.Models;
using AkademiPlusEdukator.BusinessLayer.Abstract;
using AkademiPlusEdukator.DataAccessLayer.Concrete;
using AkademiPlusEdukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusEdukator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult CourseList()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CourseList(Course course)
        {
            _courseService.TInsert(course);
            return Ok();
        }
        [HttpPut]
        public IActionResult CourseUpdate(Course course)
        {
            _courseService.TUpdate(course);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult CourseGet(int id)
        {
            var values = _courseService.TGetByID(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult CourseDelete(int id)
        {
            var value = _courseService.TGetByID(id);
            _courseService.TDelete(value);
            return Ok();
        }
        [HttpGet("CourseWithCategory")]
        public IActionResult CourseWithCategory()
        {
            var values = _courseService.TGetCoursesWithCategories();
            return Ok(values);
        }
        [HttpGet("CourseWithCategory2")]
        public IActionResult CourseWithCategory2()
        {
            Context context = new Context();
            var values = context.Courses.Include(x => x.Category).Select(y => new Deneme
            {
                CourseID = y.CourseID,
                CategoryID = y.CategoryID,
                CategoryName = y.Category.CategoryName,
                CourseTitle = y.CourseTitle,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                Score = y.Score
            }).ToList();
            return Ok(values);
        }
    }
}
