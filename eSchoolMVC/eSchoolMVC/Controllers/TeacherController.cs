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
    public class TeacherController : Controller
    {
        TeacherManager tm = new TeacherManager(new TeacherDal());
        [Authorize(Roles = "Admin")]
        public IActionResult TeacherList()
        {
            var result = tm.GetTeachers();
            return View(result);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult TeacherAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TeacherAdd(Teacher teacher)
        {
            tm.AddTeacher(teacher);
            return RedirectToAction("TeacherList");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult TeacherUpdate(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Teachers.FirstOrDefault(o => o.teacher_ID == id);
                return View(result);
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult TeacherUpdate(Teacher teacher)
        {
            var result = tm.UpdateTeacher(teacher);
            return RedirectToAction("TeacherList");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Teachers.FirstOrDefault(o => o.teacher_ID == id);
                db.Teachers.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("TeacherList");

        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
