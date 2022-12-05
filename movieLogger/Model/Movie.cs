using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieLogger.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string MPArating { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int House { get; set; }
        public float Cost { get; set; }
        public string Day { get; set; }
        public string Director { get; set; }
        public int Viewings { get; set; }

    }
}
