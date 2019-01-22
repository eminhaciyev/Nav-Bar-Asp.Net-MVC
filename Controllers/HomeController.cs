using NavBarOtherMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavBarOtherMethod.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public BlogDbCntext blogDbCntext = new BlogDbCntext();

        public ActionResult Siyaset()
        {
            var data = (from news in blogDbCntext.News
                        join menu in blogDbCntext.MenuCategories on news.MenuCategoryId equals menu.Id
                        where news.MenuCategoryId == 1
                        select news).ToList();
                       
            return View(data);
        }
        public ActionResult Idman()
        {

            var data = (from news in blogDbCntext.News
                        join menu in blogDbCntext.MenuCategories on news.MenuCategoryId equals menu.Id
                        where news.MenuCategoryId == 2
                        select news).ToList();

            return View(data);
        }
        public ActionResult Muharibe()
        {

            var data = (from news in blogDbCntext.News
                        join menu in blogDbCntext.MenuCategories on news.MenuCategoryId equals menu.Id
                        where news.MenuCategoryId == 3
                        select news).ToList();

            return View(data);
        }
    }
}