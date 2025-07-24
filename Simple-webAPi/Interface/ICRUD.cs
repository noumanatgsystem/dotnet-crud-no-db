using Simple_webAPi.Models;

namespace Simple_webAPi.Interface
{
    public interface ICRUD
    {
        string SaveStudent(Student std);
        List<Student> GetAllStudent();
        string GetStudentByEmail(string email);
        string UpdateStudent(Student std);
        string DeleteStudent(string email);
    }
}
