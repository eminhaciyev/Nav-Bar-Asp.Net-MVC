using NavBarOtherMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavBarOtherMethod.Controllers
{
    public class NewsController : Controller
    {
        // GET: News

        List<News> news = new List<News>();
        public ActionResult Index()
        {
            using (BlogDbCntext db = new BlogDbCntext())
            {
                news = db.News.Where(x => x.IsVisible == true).OrderBy(x => x.Order).ToList();                
            }
            return View(news);
        }
    }
}