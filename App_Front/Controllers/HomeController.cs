using App_Front.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;

namespace App_Front.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new CreateEditViewModel();


            return View(model);
        }

        public JsonResult GetLocation()
        {
            var a = RestAPIHelper<List<DropdownViewModel>>.Submit("", Method.Get, "api/AppValues/GetLocation");

            return Json(a);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public class RestAPIHelper<T>
        {
            public static T Submit(string jsonBody, Method httpMethod, string endpoint)
            {
                var requests = new RestRequest(httpMethod);
                requests.AddHeader("Content-Type", "application/json");
                requests.AddParameter("Authorization", string.Format("Bearer " + ""), ParameterType.HttpHeader);


                if (!string.IsNullOrEmpty(jsonBody))
                {
                    requests.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
                }

                var client = new RestClient(endpoint);
                IRestResponse response = client.Execute(requests);

                var result = JsonConvert.DeserializeObject<T>(response.Content);

                return result;
            }
        }
    }
}