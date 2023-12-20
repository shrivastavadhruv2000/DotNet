namespace HR;

public class WageEmployee:Employee{
    public int WorkingHours{
        get;set;
    }

    public WageEmployee():this(12,"Sourabh Lowanshi",8){
        
    }
    public WageEmployee(int id,string fullName, int hours):base(id,fullName){
        this.WorkingHours=hours;
    }

    public override float ComputerPay(){
       return base.ComputerPay() + WorkingHours* 600;
    }

    public override string ToString(){
        return base.ToString() + "WorkingHours = " + WorkingHours;
    }

}
