using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentCRUD.Models;

namespace StudentCRUD.Controllers
{

    public class StudentController : Controller
    {
        //
        // GET: /Student/
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            StudentMain SM = new StudentMain();
            SM.AddStudent(student);
            return RedirectToAction("AllStudentList");
        }

        public ActionResult AllStudentList()
        {
            StudentMain SM = new StudentMain();
            return View(SM.GetAllStudent().ToList());
        }

        [HttpGet]
        public ActionResult Edit(string StudentID)
        {
            StudentMain SM = new StudentMain();
            return View(SM.GetStudent(StudentID));
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            StudentMain SM = new StudentMain();
            SM.UpdateStudent(student);
            return RedirectToAction("AllStudentList");
        }

        [HttpGet]
        public ActionResult Delete(string StudentID)
        {
            StudentMain SM = new StudentMain();
            return View(SM.GetStudent(StudentID));
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            StudentMain SM = new StudentMain();
            SM.DeleteStudent(student);
            return RedirectToAction("AllStudentList");

        }
      }
}
