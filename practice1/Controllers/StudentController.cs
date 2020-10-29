using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.Models;
namespace practice1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Route("DisplayStudent")]
        public ActionResult Index()
        {
            Student stud = new Student();
            return View();
        }
    }
}