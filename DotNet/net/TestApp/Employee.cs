namespace HR;
public class Employee{
    private int id;
    private string firstName;

    public int Id{
        get{return this.id;}
        set{this.id=value;}
    }

    public string FullName{
        get;set;
    }

    public Employee():this(11,"Ashish Sharma"){
        //this.id=11;
        //this.fullNaame="Ashish Sharma
    }

    public Employee(int id,string fullName){
        this.id=id;
        this.FullName=fullName;
    }

    public virtual float ComputerPay(){
        return 50000;
    }

    public override string ToString(){
        return id+ " " +FullName + " " + ComputerPay();
    }


    
}