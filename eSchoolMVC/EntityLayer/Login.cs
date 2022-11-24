using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Login
    {
        [Key]
        public int user_ID { get; set; }
        public string user_Name { get; set; }
        public string user_Pword { get; set; }
        public string user_Role { get; set; }
    }
}
