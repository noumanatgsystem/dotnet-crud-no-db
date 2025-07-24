using Simple_webAPi.Models;

namespace Simple_webAPi.Interface
{
    public interface IStudent
    {
        string SaveStudent(Student std);
        string UpdateStudent(Student std);
        List<Student> GetAllStudents();
        Student GetStudentByEmail(string email);
        string DeleteStudent(string email);
    }
}
