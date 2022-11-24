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
    public class TeacherManager : ITeacherService
    {
        ITeacherDal teacherDal;
        public TeacherManager(ITeacherDal teacherDal)
        {
            this.teacherDal = teacherDal;
        }

        public int AddTeacher(Teacher teacher)
        {
            return teacherDal.Add(teacher);
        }

        public int DeleteTeacher(Teacher teacher)
        {
            return teacherDal.Delete(teacher);
        }

        public Teacher getTeacherByID(int id)
        {
            return teacherDal.getByID(id);
        }

        public List<Teacher> GetTeachers()
        {
            return teacherDal.GetAll();
        }

        public int UpdateTeacher(Teacher teacher)
        {
            return teacherDal.Update(teacher);
        }
    }
}
