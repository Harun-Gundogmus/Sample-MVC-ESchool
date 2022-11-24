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
    public class LessonController : Controller
    {
        LessonManager lm = new LessonManager(new LessonDal());

        [Authorize(Roles = "Admin")]
        public IActionResult LessonList()
        {
            var result = lm.GetLessons();
            return View(result);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult LessonAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LessonAdd(Lesson lesson)
        {
            lm.AddLesson(lesson);
            return RedirectToAction("LessonList");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult LessonUpdate(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Lessons.FirstOrDefault(o => o.lesson_ID == id);
                return View(result);
            }
        }
        [HttpPost]
        public IActionResult LessonUpdate(Lesson lesson)
        {
            var result = lm.UpdateLesson(lesson);

            return RedirectToAction("LessonList");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult LessonDelete(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Lessons.FirstOrDefault(o => o.lesson_ID == id);
                db.Lessons.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("LessonList");

        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
