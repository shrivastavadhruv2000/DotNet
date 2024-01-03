using MySql.Data.MySqlClient;
using BOL;
namespace DAL;

using Org.BouncyCastle.Tls;
using System.Net.Http.Headers;

public class DBManager{

    // Yaha pr Public NAhi diya hai
    static string connection_string="server=localhost;port=3306;user=root;password=123456788;database=dhruv";
    
    public static List<ProductDetail> GetProducts(){
       List<ProductDetail> list=new List<ProductDetail>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=connection_string;
        string query="Select * from products";
        MySqlCommand cmd= new MySqlCommand(query,conn);

        try{
            conn.Open();
            MySqlDataReader reader =cmd.ExecuteReader();
            while(reader.Read()){
                int Id=int.Parse(reader["id"].ToString());
                string Title=reader["title"].ToString();
                string Description =reader["description"].ToString();
                double Price=double.Parse(reader["price"].ToString());
                Console.WriteLine(Id+ " "+ Title+ " "+ Description+ " " +Price);
                ProductDetail pdt=new ProductDetail{
                    id=Id,
                    title=Title,
                    description=Description,
                    price=Price,
                };

                list.Add(pdt);
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