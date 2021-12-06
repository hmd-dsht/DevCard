using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Mvc.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Articles>
            {
                new Articles(1, "آموزش asp.net Core MVC", "blog-post-thumb-card-1.jpg", "کاملترین پکیج آموزشی"),
                new Articles(2, "آموزش asp.net Core MVC", "blog-post-thumb-card-2.jpg", "کاملترین پکیج آموزشی"),
                new Articles(3, "آموزش asp.net Core MVC", "blog-post-thumb-card-3.jpg", "کاملترین پکیج آموزشی"),
                new Articles(4, "آموزش asp.net Core MVC", "blog-post-thumb-card-4.jpg", "کاملترین پکیج آموزشی"),


            };
            return View("_LatestArticles",articles);
        }
    }
}
