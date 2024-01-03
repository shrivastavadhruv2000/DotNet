namespace BOL;

public class Student
{
    public int Sid{get; set;}
    public string Fname{get; set;}
    public string Lname{get; set;}
    public string Dob{get; set;}
    public string Email{get; set;}
    public Student(int id, string fname, string lname, string dob, string email){
        this.Sid = id;
        this.Fname = fname;
        this.Lname = lname;
        this.Dob = dob;
        this.Email = email;
    }
}
