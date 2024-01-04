namespace BOL;

public class Student{
    public int ID{get;set;}

    public string ? FirstName{get;set;}

    public string ? LastName{get;set;}

    public string ? DOB{get;set;}


    public string ? Email{get;set;}

    public Student(int id,string fname,string lname, string dob,string email){
        this.ID=id;
        this.FirstName=fname;
        this.LastName=lname;
        this.DOB=dob;
        this.Email=email;
    }

     public override string ToString()
    {
        return "(Id :" + ID + "FirstName : " + FirstName + "LastName : " + LastName + "DOB : " + DOB + "Email :" + Email + ")";

    }



}