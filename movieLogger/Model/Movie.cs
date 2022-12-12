using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieLogger.Model
{
    public class Movie
    {
        private Image Art;
        private string date;
        public string Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string MPArating { get; set; }
        public string Date
        {
            get { return date.Split(" ")[0].ToString(); }
            set { date = value; }
        }
        public string Time { get; set; }
        public string House { get; set; }
        public string Cost { get; set; }
        public string Day { get; set; }
        public string Director { get; set; }
        public string Viewings { get; set; }
        public Movie(string id, string title, string genre, string mpa, string date, string time, string house, string cost, string day, string director, string viewings)
        {
            Id= id;
            Title = title;
            Genre= genre;
            MPArating = mpa;
            Date = date;
            Time = time;
            House = house;
            Cost = cost;
            Day = day;
            Director = director;
            Viewings = viewings;
            Art = new Image { Source = "C:/Users/Jake/Documents/GitHub/DOTNET-MAUI-Movie-Logger/movieLogger/Resources/jones.jpg" };
        }

    }

}
