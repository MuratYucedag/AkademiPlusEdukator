using AkademiPlusEdukator.BusinessLayer.Abstract;
using AkademiPlusEdukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

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
    }
}
