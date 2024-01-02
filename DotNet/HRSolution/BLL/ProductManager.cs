namespace BLL;
using DAL;
using BOL;
public class ProductManager{
    public ProductManager(){

    }
    public List<Product> DisplayProduct(){
        List<Product>p=new List<Product>();
        p=DBManager.GetAllProduct();
        return p;
    }
}