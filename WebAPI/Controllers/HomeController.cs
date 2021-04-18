using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Displays Home view.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        /// <summary>
        /// Displays DisplayEmployeeInfo form view.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public ActionResult EmployeeInfo(Employee employee)
        {
            return View(employee);
        }
    }
}
