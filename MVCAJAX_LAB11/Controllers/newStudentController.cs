using MVCAJAX_LAB11.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace MVCAJAX_LAB11.Controllers
{
    public class newStudentController : Controller
    {
        private StudentService service = new StudentService();
        // GET: newStudent
        public ActionResult Index()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             ID = c.studentID,
                             Address = c.studentAddress,
                             Name = c.studentName,
                             LastName = c.studentLastName,
                             Code = c.studentCode,
                             IsActive = c.isActive
                         }).ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult FilterByNameOrLastName(string query)
        {
            return Json(service.Search(query));

        }

        [HttpPost]
        public JsonResult getStudent(string id)
        {
            return Json(service.GetById(Convert.ToInt32(id)), JsonRequestBehavior.DenyGet);
        }
    }
}