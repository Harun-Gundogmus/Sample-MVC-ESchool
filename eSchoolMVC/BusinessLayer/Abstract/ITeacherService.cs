using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeacherService
    {
        int AddTeacher(Teacher teacher);
        int UpdateTeacher(Teacher teacher);
        int DeleteTeacher(Teacher teacher);
        List<Teacher> GetTeachers();
        Teacher getTeacherByID(int id);
    }
}
