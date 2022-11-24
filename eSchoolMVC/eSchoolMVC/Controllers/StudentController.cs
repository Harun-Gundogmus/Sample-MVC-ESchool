using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace eSchoolMVC.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new StudentDal());
        [Authorize(Roles = "Admin")]
        public IActionResult StudentList()
        {
            var result = sm.GetStudents();
            return View(result);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult StudentAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentAdd(Student student)
        {
            sm.AddStudent(student);
            return RedirectToAction("StudentList");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult StudentUpdate(int id)
        {
            var result = sm.getStudentByID(id);
                return View(result);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult StudentUpdate(Student student)
        {
            var result = sm.UpdateStudent(student);

            return RedirectToAction("StudentList");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult StudentDelete(int id)
        {
            var result = sm.getStudentByID(id);
            sm.DeleteStudent(result);

            return RedirectToAction("StudentList");

        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
