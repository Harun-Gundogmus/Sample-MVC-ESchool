using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILessonService
    {
        int AddLesson(Lesson lesson);
        int UpdateLesson(Lesson lesson);
        int DeleteLesson(Lesson lesson);
        List<Lesson> GetLessons();
        Lesson getLessonByID(int id);
    }
}
