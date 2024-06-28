using System;
using System.Data;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        ServerOperations serverOperations = new ServerOperations();
        serverOperations.TakeData();

        string context = Console.ReadLine();
        int id = Convert.ToInt32(?context);
        

        //serverOperations.EnterData(context);
        //serverOperations.UpdateData(id,context);
        serverOperations.DeleteData(id);
        serverOperations.TakeData();
    }
}

public class ServerOperations
{
    public void TakeData()
    {
        string connectionString = "server=localhost;database=hyutodolist;user=root;password=;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            string query = "SELECT * FROM todotask;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int key = (int)dataReader["Keyy"];
                string item = (string)dataReader["Item"];
                Console.WriteLine(key + " - " + item);
            }

            dataReader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public void EnterData(string context)
    {
        string connectionString = "server=localhost;database=hyutodolist;user=root;password=;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            string query = "INSERT INTO todotask (Item) VALUES (@item)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@item", context);

            int rowsAffected = cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public void DeleteData(int id)
    {
        string connectionString = "server=localhost;database=hyutodolist;user=root;password=;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            string query = "DELETE FROM todotask WHERE Keyy = @key";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@key", id);

            int rowsAffected = cmd.ExecuteNonQuery();

            if(rowsAffected > 0)
            {
                Console.WriteLine("Veri başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Silme işlemi gerçekleştirilemedi. Belirtilen ID bulunamadı.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public void UpdateData(int id, string newContext)
    {
        string connectionString = "server=localhost;database=hyutodolist;user=root;password=;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            string query = "UPDATE todotask SET Item = @newContext WHERE Keyy = @id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@newContext", newContext);
            cmd.Parameters.AddWithValue("@id", id);

            int rowsAffected = cmd.ExecuteNonQuery();

            if(rowsAffected > 0)
            {
                Console.WriteLine("Veri başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Güncelleme işlemi gerçekleştirilemedi. Belirtilen ID bulunamadı.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }


}