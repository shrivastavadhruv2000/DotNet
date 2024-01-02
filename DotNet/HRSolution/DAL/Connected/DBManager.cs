using System.Linq.Expressions;

namespace DAL;
using MySql.Data.MySqlClient;
using BOL;
public static class DBManager
{
    public static string conString = @"server=localhost;port=3306;user=root; password=Purvacw@24;database=dac54";
    public static List<Product> GetAllProduct()
    {
        List<Product> plist = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from product1";
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int pid = int.Parse(reader["pid"].ToString());
                string pname = reader["pname"].ToString();
                int quantity = int.Parse(reader["quantity"].ToString());
                double price = double.Parse(reader["price"].ToString());
                Product p = new Product
                {
                    pid = pid,
                    pname = pname,
                    quantity = quantity,
                    price = price
                }; plist.Add(p);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();

        }
        return plist;
    }

    public static void InsertData(Product p)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "insert into product1 values(@pid,@pname,@quantity,@price)";
        MySqlCommand cmd = new MySqlCommand(query, con);
        cmd.Parameters.AddWithValue("@pid", p.pid);
        cmd.Parameters.AddWithValue("@pname", p.pname);
        cmd.Parameters.AddWithValue("@quantity", p.quantity);
        cmd.Parameters.AddWithValue("@price", p.price);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }

    }

    public static void DeleteData(int pid)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "delete  from product1 where pid=@pid";
        MySqlCommand cmd = new MySqlCommand(query, con);
        cmd.Parameters.AddWithValue("@pid", pid);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }
    }
    public static void UpdateData(Product p)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "update product1 set pid=@pid,pname=@pname,quantity=@quantity,price=@price where pid=@pid";
        MySqlCommand cmd = new MySqlCommand(query, con);
        cmd.Parameters.AddWithValue("@pid", p.pid);
        cmd.Parameters.AddWithValue("@pname", p.pname);
        cmd.Parameters.AddWithValue("@quantity", p.quantity);
        cmd.Parameters.AddWithValue("@price", p.price);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }

    }
    public static void RegisterData(Customer c)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "insert into Customer1 values(@cname,@contact,@email,@password)";
        MySqlCommand cmd = new MySqlCommand(query, con);
        cmd.Parameters.AddWithValue("@cname", c.cname);
        cmd.Parameters.AddWithValue("@contact", c.contact);
        cmd.Parameters.AddWithValue("@email", c.email);
        cmd.Parameters.AddWithValue("@password", c.password);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }
    }

    public static List<Customer> GetAllCustomer()
    {
        List<Customer> clist = new List<Customer>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from Customer1";
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string cname = reader["cname"].ToString();
                string contact = reader["contact"].ToString();
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                Customer c = new Customer
                {
                    cname = cname,
                    contact = contact,
                    email = email,
                    password = password
                }; 
                clist.Add(c);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();

        }
        return clist;
    }
}