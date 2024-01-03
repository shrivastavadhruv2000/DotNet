namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    private static string conString = "server=192.168.10.150;port=3306;user=dac19;password=welcome;database=dac19";
    private static MySqlConnection con = null;
    public static List<Student> getAllStudents(){
        List<Student> slist = new List<Student>();
        con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from student";
        MySqlCommand cmd = new MySqlCommand(query, con);
        try{
            con.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read()){
                int id = int.Parse(rd["ID"].ToString());
                string fname = rd["namefirst"].ToString();
                string lname = rd["namelast"].ToString();
                string dob = rd["DOB"].ToString();
                string email = rd["emailID"].ToString();
                slist.Add(new Student (id, fname, lname, dob, email));
            }
            rd.Close();
        }catch(Exception e){
            Console.WriteLine("Error: "+e.Message);
        }
        finally{
            con.Close();
        }
        return slist;
    }














    // public static Boolean validate(string email, string pass){
    //     List<User> u_list = getAllUser();
    //     foreach(User u in u_list){
    //         if(u.Email==email && u.Pass==pass)
    //             return true;
    //     }
    //     return false;
    // }
    
    // public static Boolean insert(string email, string uname, string pass){
    //     List<User> u_list = getAllUser();
    //     Boolean flag = true;
    //     foreach(User u in u_list){
    //         if(u.Email==email || u.Pass==pass)
    //             flag = false;
    //     }
    //     if(flag){
    //         string query = "insert into login values(@uname, @pass, @email)";
    //         MySqlCommand cmd = new MySqlCommand(query, con);
    //         cmd.Parameters.AddWithValue("@uname",uname);
    //         cmd.Parameters.AddWithValue("@pass", pass);
    //         cmd.Parameters.AddWithValue("@email", email);
    //         try{
    //             con.Open();
    //             cmd.ExecuteNonQuery();
    //         }
    //         catch(Exception e){
    //             Console.WriteLine("Error: "+e.Message);
    //         }
    //         finally{
    //             con.Close();
    //         }
    //         return true;
    //     }
    //     else{
    //         return false;
    //     }
    // }
    // public static Boolean update(string email, string pass){
    //     List<User> u_list = getAllUser();
    //     Boolean flag = true;
    //     foreach(User u in u_list){
    //         if(u.Email==email)
    //             flag = true;
    //     }
    //     if(flag){
    //         string query = "update login set password = @pass where email = @email";
    //         MySqlCommand cmd = new MySqlCommand(query, con);
    //         cmd.Parameters.AddWithValue("@pass", pass);
    //         cmd.Parameters.AddWithValue("@email", email);
    //         try{
    //             con.Open();
    //             cmd.ExecuteNonQuery();
    //         }
    //         catch(Exception e){
    //             Console.WriteLine("Error: "+e.Message);
    //         }
    //         finally{
    //             con.Close();
    //         }
    //         return true;
    //     }
    //     else{
    //         return false;
    //     }
    // }
}
