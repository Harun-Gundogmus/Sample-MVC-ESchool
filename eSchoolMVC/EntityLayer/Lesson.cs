using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Lesson
    {
        [Key]
        public int lesson_ID { get; set; }
        public string lesson_Name { get; set; }
        public ICollection<Student> students { get; set; }    
    }
}
