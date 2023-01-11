using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using TestEFcore.Models;

namespace TestEFcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DataContext _db;
        public HomeController(DataContext db, ILogger<HomeController> logger)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {

            #region Read api info from db

            //List<tblAPIUrls> lstAPIUrl = new List<tblAPIUrls>();
            //List<tblAPIUrlParams> lstAPIUrlParam = new List<tblAPIUrlParams>();

            //lstAPIUrl = _db.tblAPIUrls.Include(q => q.tblAPIUrlParams).ToList();

            //List<tblAPIUrlParams> p = _db.tblAPIUrlParams.ToList();

            //var lstParam = _db.tblAPIUrlParams.Select(q => new
            //{
            //    q.Id,
            //    q.tblAPIUrlsId,
            //    q.Name,
            //    q.Value
            //}).ToList();

            //var jsonParam = JsonConvert.SerializeObject(lstParam);
            //lstAPIUrlParam = JsonConvert.DeserializeObject<List<tblAPIUrlParams>>(jsonParam);


            //for (int i = 0; i < lstAPIUrl.Count; i++)
            //{
            //    lstAPIUrl[i].tblAPIUrlParams = lstAPIUrlParam.Where(q => q.tblAPIUrlsId == lstAPIUrl[i].Id).ToList();
            //}
            #endregion

            return View();
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
    }
}