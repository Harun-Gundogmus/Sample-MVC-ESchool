using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Student
    {
        [Key]
        public int student_ID { get; set; }
        public string student_Name { get; set; }
        public string student_Lastname{ get; set; }
        public int student_Number { get; set; }
        public ICollection<Teacher> teachers { get; set; }
        public Lesson lesson { get; set; }

    }
}
