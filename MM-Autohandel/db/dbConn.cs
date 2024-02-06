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

                using (var command = new NpgsqlCommand("DROP TABLE IF EXISTS newCars, usedCars, users, appointments", conn))
                {
                    command.ExecuteNonQuery();
                    Console.Out.WriteLine("Finished dropping table (if existed)");

                }

                using (var command = new NpgsqlCommand(
                    "CREATE TABLE newCars(id serial PRIMARY KEY, brand VARCHAR(50), model VARCHAR(50), whp INTEGER);" +
                    "CREATE TABLE usedCars(id serial PRIMARY KEY, brand VARCHAR(50), model VARCHAR(50), whp INTEGER, km INTEGER);" +
                    "CREATE TABLE users(id serial PRIMARY KEY, email VARCHAR(30), password VARCHAR(16));" +
                    "CREATE TABLE appointments(id serial PRIMARY KEY, date DATE, time TIME, place VARCHAR(30), userid INTEGER REFERENCES users(id));",
                    conn))
                {
                    command.ExecuteNonQuery();
                    Console.Out.WriteLine("Finished creating table");
                }

                using (var command = new NpgsqlCommand(
                    "INSERT INTO newCars (brand, model, whp) VALUES (@b1, @m1, @w1), (@b2, @m2, @w2), (@b3, @m3, @w3)",
                    conn))
                {
                    command.Parameters.AddWithValue("b1", "BMW");
                    command.Parameters.AddWithValue("m1", "M3");
                    command.Parameters.AddWithValue("w1", 200);
                    command.Parameters.AddWithValue("b2", "VW");
                    command.Parameters.AddWithValue("m2", "Golf");
                    command.Parameters.AddWithValue("w2", 120);
                    command.Parameters.AddWithValue("b3", "AUDI");
                    command.Parameters.AddWithValue("m3", "RS6");
                    command.Parameters.AddWithValue("w3", 300);

                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }

                using (var command = new NpgsqlCommand(
                    "INSERT INTO usedCars (brand, model, whp, km) VALUES (@b1, @m1, @w1, @k1), (@b2, @m2, @w2, @k2)",
                    conn))
                {
                    command.Parameters.AddWithValue("b1", "BMW");
                    command.Parameters.AddWithValue("m1", "330i");
                    command.Parameters.AddWithValue("w1", 180);
                    command.Parameters.AddWithValue("k1", 130_000);
                    command.Parameters.AddWithValue("b2", "VW");
                    command.Parameters.AddWithValue("m2", "Golf");
                    command.Parameters.AddWithValue("w2", 120);
                    command.Parameters.AddWithValue("k2", 180_000);

                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }

                using (var command = new NpgsqlCommand(
                    "INSERT INTO users (email, password) VALUES (@e1, @p1)",
                    conn))
                {
                    command.Parameters.AddWithValue("e1", "admin@mail.haendler");
                    command.Parameters.AddWithValue("p1", "123123");

                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
            };
        }

        public static List<Car> getCars(string table)
        {
            string brand;
            string model;
            int whp;
            int km;

            List<Car> cars = new List<Car>();

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();


                using (var command = new NpgsqlCommand("SELECT * FROM " + table, conn))
                {

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        brand = reader.GetString(1);
                        model = reader.GetString(2);
                        whp = reader.GetInt32(3);
                        if (table == "usedCars")
                        {
                            km = reader.GetInt32(4);
                            cars.Add(new Car(brand, model, whp, km));
                        } else
                        {
                            cars.Add(new Car(brand, model, whp));
                        }
                        
                    }
                    reader.Close();
                    return cars;
                }
            }

        }

        public static bool loginService(string email, string password)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("SELECT email, password FROM users WHERE email='" + email + "' AND password='" + password + "'", conn))
                {
                    var reader = command.ExecuteReader();
                    return reader.Read();
                }
            }
        }

        public static List<Car> filterCars(string[] inputs, string tableType)
        {
            string carBrand;
            string carModel;
            int carHp;

            List<Car> cars = new List<Car>();

            using (var conn = new NpgsqlConnection(connString)) 
            {
                conn.Open();

                SqlQuery sqlQuery = new SqlQuery();

                using (var command = new NpgsqlCommand("SELECT * FROM " + tableType + " WHERE " + sqlQuery.build(inputs) + "", conn))
                {
                    var reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        carBrand = reader.GetString(1);
                        carModel = reader.GetString(2);
                        carHp = reader.GetInt32(3);

                        cars.Add(new Car(carBrand, carModel, carHp));
                    }
                    reader.Close();
                    return cars;
                    
                }
            }
        }

    }
}
