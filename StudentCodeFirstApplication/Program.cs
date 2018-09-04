using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = 1;

            Program program = new Program();

            Console.WriteLine("Enter Your Choice:\n" +
                              "1.Display Student And Course Details:\n" +
                              "2.Add Course:\n" +
                              "3.Add Student:\n" +
                              "4.Update Student and Course Details:\n" +
                              "5.Delete Student and Course Details:\n" +
                              "6.Exit");


            select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    program.ViewStudentDetails();
                    break;
                case 2:
                    program.AddCourse();
                    break;
                case 3:
                    program.AddStudent();
                    break;
                case 4:
                    program.UpdateStudentDetails();
                    Console.ReadKey();
                    break;

                case 5:
                    program.DeleteStudentDetails();
                    break;

                default:
                    Console.WriteLine("Please Enter Number between 1 to 5");
                    Console.ReadKey();
                    break;
            }
        }
        private void AddCourse()
        {
            using (StudentDBContext studentDBContext = new StudentDBContext())
            {
                Console.Write("Enter Course Name:  ");
                string courseName = Console.ReadLine();
                Console.Write("Enter Course AcademicYear: ");
                int academicYear = Convert.ToInt32(Console.ReadLine());
                Courses courses = new Courses()
                {
                    CourseName = courseName,
                    AcademicYear = academicYear,
                };
                studentDBContext.Course.Add(courses);
                studentDBContext.SaveChanges();

                Console.ReadKey();
            }

        }
        private void AddStudent()
        {
            using (StudentDBContext studentDBContext = new StudentDBContext())
            {
                Console.Write("Enter Student FirstName :  ");
                string studentFirstName = Console.ReadLine();
                Console.Write("Enter Student Lastname : ");
                string studentLastName = Console.ReadLine();
                Console.Write("Enter the Address : ");
                string studentAddress = Console.ReadLine();
                Console.WriteLine("Enter Your Choice : ");
                foreach (var item in studentDBContext.Course)
                {
                    Console.WriteLine(item.CourseName + "=>" + item.CourseID);

                }
                int courseID = Convert.ToInt32(Console.ReadLine());
                Students student = new Students()
                {
                    FirstName = studentFirstName,
                    LastName = studentLastName,
                    Address = studentAddress,
                    CourseID = courseID,

                };
                studentDBContext.Student.Add(student);
                studentDBContext.SaveChanges();
            }
        }
        private void DeleteStudentDetails()
        {
            using (StudentDBContext studentDBContext = new StudentDBContext())
            {
                Console.Write("Enter StudentID  :  ");
                int studentID = Convert.ToInt32(Console.ReadLine());
                Students student = studentDBContext.Student.Where(x => x.StudentID == studentID).FirstOrDefault();
                if (student != null)
                    studentDBContext.Student.Remove(student);
                else
                    Console.WriteLine("StudentID is not Found ");
                studentDBContext.SaveChanges();
            }
        }
        private void UpdateStudentDetails()
        {
            using (StudentDBContext studentDBContext = new StudentDBContext())
            {
                Console.Write("Enter StudentID  :  ");
                int studentID = Convert.ToInt32(Console.ReadLine());
                Students student = studentDBContext.Student.Where(x => x.StudentID == studentID).FirstOrDefault();
                if (student != null)
                {
                    Console.Write("Enter Student FirstName :  ");
                    string studentFirstName = Console.ReadLine();
                    Console.Write("Enter Student Lastname : ");
                    string studentLastName = Console.ReadLine();
                    Console.Write("Enter the Address : ");
                    string studentAddress = Console.ReadLine();
                    Console.WriteLine("Enter Your Choice : ");
                    foreach (var item in studentDBContext.Course)
                    {
                        Console.WriteLine(item.CourseName + "=>" + item.CourseID);

                    }
                    int courseID = Convert.ToInt32(Console.ReadLine());

                    student.FirstName = studentFirstName;
                    student.LastName = studentLastName;
                    student.Address = studentAddress;
                    student.CourseID = courseID;

                }
                else
                    Console.WriteLine("StudentID is not Found ");
                studentDBContext.SaveChanges();
            }
        }
        private void ViewStudentDetails()
        {
            using (StudentDBContext studentDBContext = new StudentDBContext())
            {
                foreach (var item in studentDBContext.Student)
                {
                    Console.WriteLine(item.StudentID + "   " + item.FirstName + "    " + item.LastName + "  " + item.Address + "  " + item.CourseID);
                }
            }
            Console.ReadKey();
        }
    }
}

