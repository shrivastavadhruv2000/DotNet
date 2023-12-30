namespace web.BLL;
using System.Collections.Generic;
using BOL;
using DAL;


public class ProductManager(){
    public static List<Student> GetAll(){
        List<Student> list = new List<Student>();
        list = DBManager.GetAllStudents();
        return list;
    }
}