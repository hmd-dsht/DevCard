using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Mvc.ViewComponents
{
    public class ProjectsViewComponent: ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project>
            {
                new Project(1,"تاکسی","درخواست تاکسی برای سفرهای درون شهری","project-1.jpg","aryta"),
                new Project(2,"اسنپ فود","سرویس آنلاین درخواست غذا ","project-2.jpg","ُSnapfood"),
                new Project(3,"تاکسی","درخواست تاکسی برای سفرهای درون شهری","project-3.jpg","aryta"),
                new Project(4,"اسنپ فود","سرویس آنلاین درخواست غذا ","project-4.jpg","ُSnapfood")
            };
            return View("_Projects",Projects);
        }
    }
}
