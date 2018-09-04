using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirstApplication
{
    public class Courses
    {
        [Key]
        public int CourseID
        {
            get; set;
        }
        public string CourseName
        {
            get; set;
        }
        
        public int AcademicYear
        {
            get; set;
        }

        public ICollection<Students> Student
        {
            get; set;
        }



    }
}
