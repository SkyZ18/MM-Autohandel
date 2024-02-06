using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                    Console.WriteLine("Finished dropping table (if existed)");

                }

                using (var command = new NpgsqlCommand(
                    "CREATE TABLE newCars(id serial PRIMARY KEY, brand VARCHAR(50), model VARCHAR(50), whp INTEGER, text VARCHAR(100));" +
                    "CREATE TABLE usedCars(id serial PRIMARY KEY, brand VARCHAR(50), model VARCHAR(50), whp INTEGER, km INTEGER, text VARCHAR(100));" +
                    "CREATE TABLE users(id serial PRIMARY KEY, email VARCHAR(30), password VARCHAR(16));" +
                    "CREATE TABLE appointments(id serial PRIMARY KEY, date DATE, place VARCHAR(30), userid INTEGER REFERENCES users(id));",
                    conn))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Finished creating table");
                }

                using (var command = new NpgsqlCommand(
                    "INSERT INTO newCars (brand, model, whp, text) VALUES (@b1, @m1, @w1, @t1), (@b2, @m2, @w2, @t2), (@b3, @m3, @w3, @t3)",
                    conn))
                {
                    command.Parameters.AddWithValue("b1", "BMW");
                    command.Parameters.AddWithValue("m1", "M3");
                    command.Parameters.AddWithValue("w1", 200);
                    command.Parameters.AddWithValue("t1", "BMW mit 200PS. Schalter. I6 Motor mit 3L. V-MAX: 250km/h. Benzin Treibstoff");
                    command.Parameters.AddWithValue("b2", "VW");
                    command.Parameters.AddWithValue("m2", "GOLF");
                    command.Parameters.AddWithValue("w2", 140);
                    command.Parameters.AddWithValue("t2", "VW Golf mit 120PS. Schalter. R4 Motor mit 1.9L. V-MAX: 220km/h. Diesel Treibstoff");
                    command.Parameters.AddWithValue("b3", "AUDI");
                    command.Parameters.AddWithValue("m3", "RS6");
                    command.Parameters.AddWithValue("w3", 300);
                    command.Parameters.AddWithValue("t3", "Audi RS6 mit 300PS. Schalter. V8 Motor mit 4L. V-MAX: 300km/h. Benzin Treibstoff. Turbogeladen");

                    int nRows = command.ExecuteNonQuery();
                    Console.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }

                using (var command = new NpgsqlCommand(
                    "INSERT INTO usedCars (brand, model, whp, km, text) VALUES (@b1, @m1, @w1, @k1, @t1), (@b2, @m2, @w2, @k2, @t2)",
                    conn))
                {
                    command.Parameters.AddWithValue("b1", "BMW");
                    command.Parameters.AddWithValue("m1", "330I");
                    command.Parameters.AddWithValue("w1", 180);
                    command.Parameters.AddWithValue("k1", 130_000);
                    command.Parameters.AddWithValue("t1", "BMW mit 180PS. 130k gelaufen. Top zustand. Rostfrei. Scheckheftgepflegt. Tüv 2 Jahre.");
                    command.Parameters.AddWithValue("b2", "VW");
                    command.Parameters.AddWithValue("m2", "GOLF");
                    command.Parameters.AddWithValue("w2", 120);
                    command.Parameters.AddWithValue("k2", 180_000);
                    command.Parameters.AddWithValue("t2", "VW mit 120PS. 180k gelaufen. Rost am vorderen Kotflügel. Tüv 1 Jahr");

                    int nRows = command.ExecuteNonQuery();
                    Console.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }

                using (var command = new NpgsqlCommand(
                    "INSERT INTO users (email, password) VALUES (@e1, @p1)",
                    conn))
                {
                    command.Parameters.AddWithValue("e1", "admin@mail.haendler");
                    command.Parameters.AddWithValue("p1", "123123");

                    int nRows = command.ExecuteNonQuery();
                    Console.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
            };
        }

        public static List<Car> getCars(string table)
        {
            string brand;
            string model;
            int whp;
            int km;
            string description;

            List<Car> cars = new List<Car>();

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.WriteLine("Opening connection");
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
                            description = reader.GetString(5);
                            cars.Add(new Car(brand, model, whp, km, description));
                        } else
                        {
                            description = reader.GetString(4);
                            cars.Add(new Car(brand, model, whp, description));
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
            string description;

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
                        description = reader.GetString(5);

                        cars.Add(new Car(carBrand, carModel, carHp, description));
                    }
                    reader.Close();
                    return cars;
                    
                }
            }
        }

        public static void createAppointment(Appointments appointments)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("INSERT INTO appointments (date, place, userid) VALUES (@d1, @p1, @u1)", conn))
                {
                    command.Parameters.AddWithValue("d1", appointments.GetDate());
                    command.Parameters.AddWithValue("p1", appointments.GetPlace());
                    command.Parameters.AddWithValue("u1", appointments.getUserid());

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void createNewUser(string email, string password)
        {
            using (var conn = new NpgsqlConnection(connString)) 
            {
                conn.Open();

                using (var command = new NpgsqlCommand("INSERT INTO users (email, password) VALUES (@e1, @p1)", conn))
                {
                    command.Parameters.AddWithValue("e1", email);
                    command.Parameters.AddWithValue("p1", password);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
