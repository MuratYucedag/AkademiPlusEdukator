using AkademiPlusEdukator.BusinessLayer.Abstract;
using AkademiPlusEdukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusEdukator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _featureService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            _featureService.TInsert(feature);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFeature(Feature feature)
        {
            _featureService.TUpdate(feature);
            return Ok();
        }
    }
}
