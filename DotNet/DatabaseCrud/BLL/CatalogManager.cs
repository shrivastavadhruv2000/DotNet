namespace BLL;
using System.Collections.Generic;
using DAL;
using BOL;

public class CataLogManager{
    public List<Student> GetAllStudents(){
        List<Student> list=new List<Student>();
        list=DBManager.GetAllStudents();
        return list;
    }
}