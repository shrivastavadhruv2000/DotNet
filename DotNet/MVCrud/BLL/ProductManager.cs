using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
namespace BLL;
using BOL;
using DAL;



public  class ProductManager{
    public  List<ProductDetail> GetProducts(){
        List<ProductDetail> list=new List<ProductDetail>();
        list=DBManager.GetProducts();
    
        return list;
    
    }

}
    

     