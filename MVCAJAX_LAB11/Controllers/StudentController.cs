using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;
using Domain;
using MVCAJAX_LAB11.Models;

namespace MVCAJAX_LAB11.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             ID = c.studentID,
                             Address = c.studentAddress,
                             Name = c.studentName,
                             LastName = c.studentLastName,
                             Code = c.studentCode
                         }).ToList();

            return View(model);
        }

        public JsonResult getStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult createStudent(Student student)
        {
            service.Insert(student);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }



    }
}