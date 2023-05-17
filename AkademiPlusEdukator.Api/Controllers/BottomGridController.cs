using AkademiPlusEdukator.BusinessLayer.Abstract;
using AkademiPlusEdukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridController : ControllerBase
    {
        private readonly IBottomGridService _bottomGridService;
        public BottomGridController(IBottomGridService bottomGridService)
        {
            _bottomGridService = bottomGridService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _bottomGridService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBottomGrid(BottomGrid bottomGrid)
        {
            _bottomGridService.TInsert(bottomGrid);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBottomGrid(int id)
        {
            var value = _bottomGridService.TGetByID(id);
            _bottomGridService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBottomGrid(int id)
        {
            var value = _bottomGridService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBottomGridService(BottomGrid bottomGrid)
        {
            _bottomGridService.TUpdate(bottomGrid);
            return Ok();
        }
    }
}
