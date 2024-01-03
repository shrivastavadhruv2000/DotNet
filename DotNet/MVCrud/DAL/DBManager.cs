using MySql.Data.MySqlClient;
using BOL;
namespace DAL;

using Org.BouncyCastle.Tls;
using System.Net.Http.Headers;

public class DBManager{

    // Yaha pr Public NAhi diya hai
    static string connection_string="server=192.168.10.150;port=3306;user=dac19;password=welcome;database=dac19";
    
    public static List<Product> GetProducts(){
       List<Product> list=new List<Product>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connection_string;
        string query="Select * from Product";
        MySqlCommand cmd= new MySqlCommand(query,conn);

        try{
            conn.Open();
            MySqlDataReader reader =cmd.ExecuteReader();
            while(reader.Read()){
                int Id=int.Parse(reader["id"].ToString()+"");
                string Title=reader["title"].ToString();
                string Description =reader["description"].ToString();
                double Prize=double.Parse(reader["prize"].ToString());
                Product pdt=new Product{
                    id=Id,
                    title=Title,
                    description=Description,
                    prize=Prize,
                };

                list.Add(pdt);
            }
            reader.Close();

        }
        catch(Exception e){
            Console.WriteLine(e.Message);

        }finally{
            conn.Close();
        }

       return list; 
    }
    

}