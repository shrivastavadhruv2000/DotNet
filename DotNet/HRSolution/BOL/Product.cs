namespace BOL;
public class Product{
    public int pid;
    public string pname;
    public int quantity;
    public double price;
    public Product(){
        pid=0;
        pname=null;
        quantity=0;
        price=0;
    }
    public Product(int id,string nm,int qty,double p){
        pid=id;
        pname=nm;
        quantity=qty;
        price=p;
    }
    public override string ToString(){
        return pid+" "+pname+" "+quantity+" "+price;
    }
}