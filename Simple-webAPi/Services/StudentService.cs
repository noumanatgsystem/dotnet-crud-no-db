using Simple_webAPi.Interface;
using Simple_webAPi.Models;

namespace Simple_webAPi.Services
{
    public class StudentService : IStudent
    {
        public static List<Student> StudentList = new List<Student>();

        public string SaveStudent(Student std)
        {
            var exsistingStd = StudentList.FirstOrDefault(s => s.Email == std.Email);
            if(exsistingStd != null)
            {
                return "User Already Exsists with this email";
            }
            StudentList.Add(std);
            return "saved";
        }


        public string UpdateStudent(Student std)
        {
            var exsistingStd = StudentList.FirstOrDefault(s => s.Email == std.Email);
            if(exsistingStd != null)
            {
                exsistingStd.Age = std.Age;
                exsistingStd.Name = std.Name;
                return "Updated Sucess";
            }
            return "No Student Found with this email";
        }


        public List<Student> GetAllStudents()
        {
            return StudentList;
        }

        public Student GetStudentByEmail(string email)
        {
            var exsistingStd = StudentList.FirstOrDefault(s => s.Email == email);
            if(exsistingStd == null)
            {
                return new Student();
            }
            return exsistingStd;
        }


        public string DeleteStudent(string email)
        {
            var exsistingStd = StudentList.FirstOrDefault(s => s.Email == email);
            if(exsistingStd == null)
            {
                return "No Student Found with this email";
            }
            StudentList.Remove(exsistingStd);
            return "Deleted Sucess";
        }

    }
}
