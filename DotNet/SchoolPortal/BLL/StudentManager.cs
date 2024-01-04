using DAL;
using BOL;

namespace BLL;
public class StudentManager{
 

    public  List<Student> GetAllStudent()
    {
        List<Student> list=new List<Student>();
        list=DBManager.GetAllStudent();
       
         return list;
    }


}