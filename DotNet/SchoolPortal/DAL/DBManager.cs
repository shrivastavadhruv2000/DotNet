using BOL;
namespace DAL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

// using Org.BouncyCastle.Asn1.Misc;

public class DBManager{
   public static string  conn_string="server=localhost;port=3306;user=root;password=123456788;database=dhruv";

    public static List<Student> GetAllStudent(){
        List<Student> list=new List<Student>();

        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=conn_string;
        string query="select * from student";
        MySqlCommand cmd=new MySqlCommand(query,conn);

        try{
            conn.Open();
            MySqlDataReader reader=cmd.ExecuteReader();

            while(reader.Read()){
                int id=int.Parse(reader["ID"].ToString());
                string ? fname= reader["FirstName"].ToString();
                string ? lname= reader["LastName"].ToString();
                string ? dob= reader["DOB"].ToString();
                string ? email= reader["Email"].ToString();
            
                Student s=new Student{
                    ID=id,
                    FirstName=fname,
                    LastName=lname,
                    DOB=dob,
                    Email=email,
                };
                list.Add(s);
            }    


        }
        catch(Exception e){
            Console.WriteLine(e.Message);

        }
        finally{
            conn.Close();

        }
        
        return list;
    }

    public static void DeleteById(int id){
        //bool status=false;
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString = conn_string;

        string query="delete from Student where Id=@id";
        MySqlCommand cmd= new MySqlCommand(query,conn);
       cmd.Parameters.AddWithValue("@ID", id);

        try{
            conn.Open();
            cmd.ExecuteNonQuery();
            

        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }
       
    }


    public static void InsertData(int ID,string FirstName,string LastName,string DOB,string Email){
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=conn_string;
        string query="insert into student(ID,FirstName,LastName,DOB,Email) values(@ID,@FirstName,@LastName,@DOB,@Email)";
        MySqlCommand cmd=new MySqlCommand(query,conn);

        cmd.Parameters.AddWithValue("@ID",ID);
        cmd.Parameters.AddWithValue("@FirstName",FirstName);
        cmd.Parameters.AddWithValue("@LastName",LastName);
        cmd.Parameters.AddWithValue("@DOB",DOB);
        cmd.Parameters.AddWithValue("@Email",Email);

        try{
            conn.Open();
            cmd.ExecuteNonQuery();

        }
        catch(Exception e){
            Console.WriteLine(e.Message);

        }
        finally{
            conn.Close();
        }


    }

    public static void UpdateData(int ID,string FirstName,string LastName){
         MySqlConnection conn=new MySqlConnection();
         conn.ConnectionString=conn_string;
         string query="update student set FirstName=@FirstName,LastName=@LastName where ID=@ID";

         MySqlCommand cmd=new MySqlCommand(query,conn);
         cmd.Parameters.AddWithValue("@ID",ID);
         cmd.Parameters.AddWithValue("@FirstName",FirstName);
         cmd.Parameters.AddWithValue("@LastName",LastName);

         try{
             conn.Open();
             cmd.ExecuteNonQuery();
         }
         catch(Exception e){
             Console.WriteLine(e.Message);
         }
         finally{
            conn.Close();
         }
    }


    public static Student GetById(int ID){
        Student student_found=null;
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=conn_string;

        string query="select * from student where ID=@ID";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@ID",ID);

       try{
            conn.Open();
            MySqlDataReader reader=cmd.ExecuteReader();

            while(reader.Read()){
                int id=int.Parse(reader["ID"].ToString());
                string ? fname= reader["FirstName"].ToString();
                string ? lname= reader["LastName"].ToString();
                string ? dob= reader["DOB"].ToString();
                string ? email= reader["Email"].ToString();
            
                student_found=new Student{
                    ID=id,
                    FirstName=fname,
                    LastName=lname,
                    DOB=dob,
                    Email=email,
                };
                
            }reader.Close();  


        }
        catch(Exception e){
            Console.WriteLine(e.Message);

        }
        finally{
            conn.Close();

        }
        
        return student_found;


    }






}