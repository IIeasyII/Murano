using AutoMapper;
using Murano.API;
using Murano.API.Interfaces;
using Murano.DAL;
using Murano.DAL.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Murano.Models;
using System.Threading.Tasks;
using Murano.DBRepository;

namespace Murano.Controllers
{
    public class HomeController : Controller
    {
        Repository Repository;

        public HomeController()
        {
            Repository = new Repository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowResults()
        {
            #region Google

            var ApiGoogle = new Api<GoogleResult>();

            var parameters1 = new Dictionary<string, string>();

            parameters1.Add("key", "AIzaSyB6sL73ho95n7Q1B9fFnNyZyFn-ZPRtJaA");
            parameters1.Add("cx", "014788526872000520599:vbmnfgowlfs");
            parameters1.Add("q", Request["search"]);

            var request1 = new Request
            {
                Service = "https://www.googleapis.com/customsearch/v1",
                Parameters = parameters1
            };
            
            //result = ApiGoogle.SendRequestAsync(request1);
            #endregion

            #region Yandex
            //ServicePointManager.Expect100Continue = false;

            //var paramss = new Dictionary<string, string>();

            //paramss.Add("key", "03.939327849:b003e74e2fbcc40b6f7b9187013eee2b");
            //paramss.Add("user", "ieasyi");
            //paramss.Add("query", Request["search"]);

            //var request = new Request
            //{
            //    Service = "https://yandex.ru/search/xml",
            //    Parameters = paramss
            //};
            #endregion

            #region Bing

            var ApiBing = new Api<BingResult>();

            var parameters2 = new Dictionary<string, string>();

            parameters2.Add("customconfig", "5ac59235-1cc7-4b46-8e12-2bd6748787e2");
            parameters2.Add("q", Request["search"]);
            parameters2.Add("count", "10");            

            var headers = new Dictionary<string, string>();
            headers.Add("Ocp-Apim-Subscription-Key", "874a7e9d18fd4de7927a1c3b36f8edea");

            var request2 = new Request
            {
                Service = "https://api.cognitive.microsoft.com/bingcustomsearch/v7.0/search",
                Parameters = parameters2,
                Headers = headers
            };

            //result = ApiBing.SendRequestAsync(request2);
            #endregion

            dynamic result;

            result = Task.Run(() => ApiGoogle.SendRequestAsync(request1));
            result = Task.Run(() => ApiBing.SendRequestAsync(request2));

            Repository.Save(result);

            return View(result);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ShowResultsFromDB()
        {
            var model = Repository.Find(Request["search"]);

            return View(model);
        }
    }
}