namespace DAL;
using BOL;
using MySql.Data.MySqlClient;


public class DBManager{

    public static string connection_string="server=localhost;port=3306;user=root;password=123456788;database=dhruv";

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
                string namefirst=reader["FirstName"].ToString();
                string namelast =reader["LastName"].ToString();
                string dob=reader["DOB"].ToString();
                string email=reader["Email"].ToString();
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

    public static void insertStudent(int id,string fname,string lname,string dob,string email){
        MySqlConnection conn=new MySqlConnection();
       // bool status=false;
        conn.ConnectionString=connection_string;
        string query ="insert into student(ID,FirstName,LastName,DOB,Email) values('" + id +"','" + fname +"','" +lname + "','" +dob + "','"+ email + "')";
        MySqlCommand cmd= new MySqlCommand(query,conn);

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
            //return status;
        }

    public static void loginStudent(int id,string email){
        MySqlConnection conn=new MySqlConnection;
        conn.ConnectionString=connection_string;

        string query="select ID,Email from student";
        MySqlCommand cmd=new MySqlCommand(query,conn);

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
    

