using AkademiPlusEdukator.PresentationLayer.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AkademiPlusEdukator.PresentationLayer.ViewComponents.Default
{
    public class _CoursePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CoursePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
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
    }
}
