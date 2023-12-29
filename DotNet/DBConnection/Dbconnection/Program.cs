using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

MySqlConnection connection =new MySqlConnection();
connection.ConnectionString="server=192.168.10.150;port=3306;user=dac19;password=welcome;database=dac19";
string query="select * from student";
MySqlCommand command=new MySqlCommand(query,connection);
try{
    connection.Open();
    MySqlDataReader reader=command.ExecuteReader();
    while(reader.Read()){
        int id=int.Parse(reader["ID"].ToString());
        string namefirst=reader["namefirst"].ToString();
        string namelast =reader["namelast"].ToString();
        string dob=reader["DOB"].ToString();
        string email=reader["emailId"].ToString();
        Console.WriteLine(id+ " "+ namefirst+ " "+ namelast+ " " + dob + " " +email);

    } 
    reader.Close();

    command.ExecuteNonQuery();

}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}
