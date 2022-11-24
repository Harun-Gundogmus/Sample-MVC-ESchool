using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Teacher
    {
        [Key]
        public int teacher_ID { get; set; }
        public string teacher_Name { get; set; }
        public string teacher_Surname { get; set; }
        public ICollection<Student> students { get; set; }

    }
}
