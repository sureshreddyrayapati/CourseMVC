using CourceMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourceMVC.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course(){Cid=1,CName="programming Basics",CFee=25000,Technology="c#",CStartDate=new DateTime(day:01,month:01,year:2024),CEndDate=new DateTime(day:30,month:03,year:2024)},
            new Course(){Cid=2,CName="Web Fundamentals",CFee=15000,Technology="HTML,CSS And JAVASCRIPT",CStartDate=new DateTime(day:01,month:03,year:2024),CEndDate=new DateTime(day:30,month:06,year:2024)},
            new Course(){Cid=3,CName="DataBase",CFee=23000,Technology="SQL",CStartDate=new DateTime(day:01,month:01,year:2024),CEndDate=new DateTime(day:20,month:02,year:2024)},
            new Course(){Cid=4,CName="Gaming",CFee=35000,Technology="Python",CStartDate=new DateTime(day:01,month:02,year:2024),CEndDate=new DateTime(day:30,month:05,year:2024)},

        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                courses.Add(course);
                return RedirectToAction("Index");
            }
            return View(courses);
        }
    }
}