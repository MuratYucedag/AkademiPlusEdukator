using AkademiPlusEdukator.PresentationLayer.Dtos;
using AkademiPlusEdukator.PresentationLayer.Dtos.Course;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace AkademiPlusEdukator.PresentationLayer.Controllers
{
    public class CourseController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CourseController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v = "Kurs İşlemleri";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7206/api/Course/CourseWithCategory2");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCourseWithCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddCourse()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7206/api/Category/CategoryList");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

            List<SelectListItem> CategoryList = new List<SelectListItem>();
            foreach (var item in values)
            {
                var category = new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.CategoryID.ToString()
                };
                CategoryList.Add(category);
            }
            ViewBag.Categories = CategoryList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse(CreateCourseDto createCourseDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCourseDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7206/api/Course", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.DeleteAsync($"https://localhost:7206/api/Course/{id}");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCourse(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7206/api/Course/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateCourseDto>(jsonData);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCourse(UpdateCourseDto updateCourseDto)
        {
            var client=_httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCourseDto);
            StringContent stringContent=new StringContent (jsonData, Encoding.UTF8, "application/json");
            await client.PutAsync("https://localhost:7206/api/Course/", stringContent);
            return RedirectToAction("Index");
        }
    }
}
