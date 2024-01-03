namespace BLL;
using DAL;
using BOL;

public class StudentManager
{
    public List<Student> getStudents(){
        return DBManager.getAllStudents();
    }
}
