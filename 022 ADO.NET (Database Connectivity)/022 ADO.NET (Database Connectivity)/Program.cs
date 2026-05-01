using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ADO.NET Complete Demo ===\n");

        // ============================
        // CONNECTION STRING
        // ============================
        // Change DB name according to your system
        string connectionString = "Data Source=.;Initial Catalog=TestDB;Integrated Security=True";

        // Create connection object
        SqlConnection conn = new SqlConnection(connectionString);

        try
        {
            // ============================
            // OPEN CONNECTION
            // ============================
            conn.Open();
            Console.WriteLine("Connection Successful!\n");

            // ============================
            // COMMAND OBJECT (INSERT)
            // ============================
            string insertQuery = "INSERT INTO Students(Name) VALUES('Gaurav')";

            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

            insertCmd.ExecuteNonQuery();
            Console.WriteLine("Data Inserted Successfully!\n");

            // ============================
            // COMMAND OBJECT (SELECT)
            // ============================
            string selectQuery = "SELECT * FROM Students";

            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);

            // ============================
            // DATAREADER (CONNECTED MODE)
            // ============================
            SqlDataReader reader = selectCmd.ExecuteReader();

            Console.WriteLine("Data using DataReader (Connected Mode):");

            while (reader.Read())
            {
                // Read each row
                Console.WriteLine(reader["Name"].ToString());
            }

            // Close reader before next operation
            reader.Close();


            // ============================
            // DATASET (DISCONNECTED MODE)
            // ============================
            Console.WriteLine("\nData using DataSet (Disconnected Mode):");

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            DataSet ds = new DataSet();

            // Fill dataset
            adapter.Fill(ds, "Students");

            // Loop through dataset
            foreach (DataRow row in ds.Tables["Students"].Rows)
            {
                Console.WriteLine(row["Name"]);
            }
        }
        catch (Exception ex)
        {
            // Handle errors
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // ============================
            // CLOSE CONNECTION
            // ============================
            conn.Close();
            Console.WriteLine("\nConnection Closed.");
        }

        Console.WriteLine("\n=== Program End ===");
    }
}