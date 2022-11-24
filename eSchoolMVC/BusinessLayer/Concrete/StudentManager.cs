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
    public class StudentManager : IStudentService
    {
        IStudentDal studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            this.studentDal = studentDal;
        }
        public int AddStudent(Student student)
        {
            return studentDal.Add(student);
        }

        public int DeleteStudent(Student student)
        {
            return studentDal.Delete(student);
        }

        public Student getStudentByID(int id)
        {
            return studentDal.getByID(id);
        }

        public List<Student> GetStudents()
        {
            return studentDal.GetAll();
        }

        public int UpdateStudent(Student student)
        {
            return studentDal.Update(student);
        }
    }
}
