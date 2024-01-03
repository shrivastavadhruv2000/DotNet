using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
namespace BLL;
using BOL;
using DAL;



public  class ProductManager{
    public  List<Product> GetProducts(){
        List<Product> list=new List<Product>();
        list=DBManager.GetProducts();
    
        return list;
    
    }

}
    

     