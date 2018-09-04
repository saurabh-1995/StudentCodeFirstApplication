using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirstApplication
{
    public class Students
    {
        [Key]
        public int StudentID
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public int CourseID
        {
            get; set;
        }
        public Courses Courses
        {
            get; set;
        }
        



    }
}
