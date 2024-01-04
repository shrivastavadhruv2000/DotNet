using BOL;
namespace DAL;
using MySql.Data.MySqlClient;
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




}