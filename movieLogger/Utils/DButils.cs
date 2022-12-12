using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using movieLogger;
using movieLogger.Pages;
using movieLogger.ViewModel;
using MySqlConnector;

namespace ITS440_JakeStewart_FinalProject
{
    public static class DButils
    {

        public static MySqlConnection createConnection()
        {
            string connString = "server=database-1.cw3kvnvpmpee.us-east-2.rds.amazonaws.com;"
                + "port=3306;"
                + "database=Movies;"
                + "UserID=admin;"
                + "SSL Mode=None;"
                + "password=Password;";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }

        public static MySqlDataReader getAll(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM movies ORDER BY date";
            cmd.Connection = conn;
            MySqlDataReader rows = cmd.ExecuteReader();
            return rows;
        }

        public static async void insertNewMovie(MySqlConnection conn, string title, string g, string m, string date, 
                                                string time, int h, double c, string day, string director, int v)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO movies (title, genre, mpaRating, date, time, house, cost, day, director, viewings) "
                + "VALUES (@title, @genre, @mpaRating, @date, @time, @house, @cost, @day, @director, @viewings);";
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@genre", g);
            cmd.Parameters.AddWithValue("@mpaRating", m);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@house", h);
            cmd.Parameters.AddWithValue("@cost", c);
            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@director", director);
            cmd.Parameters.AddWithValue("@viewings", v);

            cmd.Connection = conn;
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Movie successfully logged!", "OK");
                
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "ERROR! No changes were made.", "OK");
            }
        }

    }
}
