using AkademiPlusEdukator.PresentationLayer.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AkademiPlusEdukator.PresentationLayer.ViewComponents.Default
{
    public class _BottomGridPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _BottomGridPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7206/api/BottomGrid");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBottomGridDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
