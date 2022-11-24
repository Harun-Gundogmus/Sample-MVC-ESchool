using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LessonManager : ILessonService
    {
        ILessonDal lessondal;
        public LessonManager(ILessonDal lessondal)
        {
            this.lessondal = lessondal;
        }
        public int AddLesson(Lesson lesson)
        {
            return lessondal.Add(lesson);
        }

        public int DeleteLesson(Lesson lesson)
        {
            return lessondal.Delete(lesson);
        }

        public Lesson getLessonByID(int id)
        {
            return lessondal.getByID(id);
        }

        public List<Lesson> GetLessons()
        {
            return lessondal.GetAll();
        }

        public int UpdateLesson(Lesson lesson)
        {
            return lessondal.Update(lesson);
        }
    }
}
