using NavBarOtherMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavBarOtherMethod.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            List<MenuCategory> menuCategories = new List<MenuCategory>();
            using (BlogDbCntext db = new BlogDbCntext())
            {
                menuCategories = db.MenuCategories.Where(x => x.IsVisible == true).OrderBy(x => x.Order).ToList();
            }
            return View(menuCategories);
        }
    }
}