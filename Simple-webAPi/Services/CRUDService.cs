using Simple_webAPi.Interface;
using Simple_webAPi.Models;

namespace Simple_webAPi.Services
{
    public class CRUDService : ICRUD
    {
        public static List<Student> StudentList = new List<Student>();
        public string SaveStudent(Student std)
        {
            var exsistingStd = StudentList.FirstOrDefault(s => s.Email == std.Email);
            if(exsistingStd != null)
            {
                return "Student Already Exsists with this email";
            }
            Student newStd = new Student
            {
                Name = std.Name,
                Age = std.Age,
                Email = std.Email
            };

            StudentList.Add(newStd);

            return "Student Created";
        }


        public List<Student> GetAllStudent()
        {
            var allStudents = new List<Student>();
            if(StudentList.Count == 0)
            {
                return allStudents;
            }

            foreach (var std in StudentList)
            {
                Console.WriteLine($"Name: {std.Name}\n, Age: {std.Age}\n, Email: {std.Email}\n");
                allStudents.Add(std);
               
            }
            return allStudents;
        }


        public string GetStudentByEmail(string email)
        {
            var std = StudentList.FirstOrDefault(s => s.Email == email);
            if (std == null)
            {
                return "Student Not Found";
            }
            return $"Name: {std.Name}, Age: {std.Age}, Email: {std.Email}";
        }


        public string UpdateStudent(Student std)
        {
            var exsistiingStd = StudentList.FirstOrDefault(s => s.Email == std.Email);
            if(exsistiingStd != null)
            {
                exsistiingStd.Age = std.Age;
                exsistiingStd.Name = std.Name;
                return "Student Updated Successfully";
            }
                return "Student Not Found";
        }

        public string DeleteStudent(string email)
        {
            var exsistinfSTd = StudentList.FirstOrDefault(s => s.Email == email);
            if(exsistinfSTd != null)
            {
                StudentList.Remove(exsistinfSTd);
                return "Student Removed Successfully";
            }
            return "No Student Found";
        }


       
    }
}
