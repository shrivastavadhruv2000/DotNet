namespace DAL;
using BOL;
using MySql.Data.MySqlClient;


public class DBManager{

    public static string connection_string="server=192.168.10.150;port=3306;user=dac19;password=welcome;database=dac19";

    public static List<Student> GetAllStudents(){
        List<Student> list=new List<Student>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connection_string;
        string query="Select * from Student";
        MySqlCommand command=new MySqlCommand(query,conn);

        try{
            
            conn.Open();
            MySqlDataReader reader=command.ExecuteReader();

            while(reader.Read()){
                
                int id=int.Parse(reader["ID"].ToString());
                string namefirst=reader["namefirst"].ToString();
                string namelast =reader["namelast"].ToString();
                string dob=reader["DOB"].ToString();
                string email=reader["emailId"].ToString();
                Console.WriteLine(id+ " "+ namefirst+ " "+ namelast+ " " + dob + " " +email);
                Student s = new Student{
                    ID=id,
                    FirstName=namefirst,
                    LastName=namelast,
                    DOB=dob,
                    Email=email,


                };
                list.Add(s);

            }
            reader.Close();

        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }
        return list;

    }
    

}