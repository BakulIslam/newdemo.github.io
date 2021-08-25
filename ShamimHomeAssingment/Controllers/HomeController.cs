using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShamimHomeAssingment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult ShowAllStudents()
        {
            return View();
        }

        public ActionResult ShowAllStudentsAdmin()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}