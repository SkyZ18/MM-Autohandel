using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MM_Autohandel.db
{
    internal class dbConn
    {
        private static string Host = "localhost";
        private static string User = "autohaendler";
        private static string DBname = "postgres";
        private static string Password = "123123";
        private static string Port = "5432";
        private static string connString =
            String.Format(
                "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                Host,
                User,
                DBname,
                Port,
                Password
                );

        public static void createConnection()
        {
            using (var conn = new NpgsqlConnection(connString)) {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                using (var command = new NpgsqlCommand("DROP TABLE IF EXISTS cars", conn))
                {
                    command.ExecuteNonQuery();
                    Console.Out.WriteLine("Finished dropping table (if existed)");

                }

                using (var command = new NpgsqlCommand("CREATE TABLE cars(id serial PRIMARY KEY, brand VARCHAR(50), model VARCHAR(50), whp INTEGER)", conn))
                {
                    command.ExecuteNonQuery();
                    Console.Out.WriteLine("Finished creating table");
                }

                using (var command = new NpgsqlCommand("INSERT INTO cars (brand, model, whp) VALUES (@b1, @m1, @w1)", conn))
                {
                    command.Parameters.AddWithValue("b1", "BMW");
                    command.Parameters.AddWithValue("m1", "M3");
                    command.Parameters.AddWithValue("w1", 150);

                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
            };
        }

        public static Car getCars()
        {
            string brand = null;
            string model = null;
            int whp = 0;

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();


                using (var command = new NpgsqlCommand("SELECT * FROM cars", conn))
                {

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        brand = reader.GetString(1);
                        model = reader.GetString(2);
                        whp = reader.GetInt32(3);
                    }
                    reader.Close();
                    return new Car(brand, model, whp);
                }
            }

        }

    }
}
