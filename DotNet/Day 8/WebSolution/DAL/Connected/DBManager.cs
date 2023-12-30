using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace DAL;
using  BOL;
public static class DBManager{
    public static List<Student> GetAllStudents(){
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=192.168.10.150;port=3306;user=dac19;password=welcome;database=dac19";
        string query="select * from student";
        List<Student> Studlist =  new List<Student>();

        MySqlCommand command=new MySqlCommand(query,connection);
        try{
            connection.Open();
            // command.ExecuteNonQuery();
            MySqlDataReader reader=command.ExecuteReader();
            while(reader.Read()){
                int id=int.Parse(reader["ID"].ToString());
                string namefirst=reader["namefirst"].ToString();
                string namelast =reader["namelast"].ToString();
                string dob=reader["DOB"].ToString();
                string email=reader["emailId"].ToString();

                Student s =new Student();
                s.ID=id;
                s.Firstname=namefirst;
                s.Lastname=namelast;
                s.DOB=dob;
                s.Email=email;
                Studlist.Add(s);
                Console.WriteLine(id+ " "+ namefirst+ " "+ namelast+ " " + dob + " " +email);

            }
            reader.Close();

           


        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return Studlist;
    }
}
