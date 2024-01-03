namespace BOL;

public class Student{
    public int ID{get;set;}

    public String FirstName{get;set;}

    public String LastName{get;set;}

    public String DOB{get;set;}

    public String Email{get;set;}

    public Student(){
        
    }
    //public Student():this(05,"Student","Student","00-00-0000","student@gmail.com"){}

    public Student(int id,string fname,string lname,string dob,string email){
        this.ID=id;
        this.FirstName=fname;
        this.LastName=lname;
        this.DOB=dob;
        this.Email=email;
    }
    
    public Student(int id,string email){
        this.ID=id;
        this.Email=email;
    }
    // public override string ToString(){
    //     return "ID:" + ID+"Name:" + FirstName + " " + LastName + "Dob:" + DOB + "Email" + Email;
    // }
}